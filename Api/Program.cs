using AsyncKeyedLock;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Api;

public partial class Program
{
    private static void Main(string[] args)
    {
        using var webApp = CreateWebApp(args);

        webApp.Run();
    }

    public static WebApplication CreateWebApp(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOpenApi();

        var app = builder.Build();

        RegisterAsyncLockerEndpoint(app);
        RegisterAsyncLockerEndpoint_LockAsync(app);
        RegisterAsyncLockerEndpoint_LockAsync_NoPooling(app);
        RegisterNativeLock(app);

        return app;
    }

    private static void RegisterAsyncLockerEndpoint(WebApplication app)
    {
        var lockId = Guid.NewGuid();
        var locker = new AsyncKeyedLocker<Guid>();
        var protectedList = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/async-locker", (Request request) => PopOrPush(request, protectedList))
            .AddEndpointFilter(async (context, next) =>
            {
                using var @lock = locker.LockOrNull(lockId, 0);

                if (@lock == null) return Results.StatusCode(423); // 423 - Locked

                return await next(context);
            });
    }

    private static void RegisterAsyncLockerEndpoint_LockAsync(WebApplication app)
    {
        var lockId = Guid.NewGuid();
        var locker = new AsyncKeyedLocker<Guid>();
        var protectedList = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/async-locker-lock-async", (Request request) => PopOrPush(request, protectedList))
            .AddEndpointFilter(async (context, next) =>
            {
                using var @lock = await locker.LockOrNullAsync(lockId, 0);

                if (@lock == null) return Results.StatusCode(423); // 423 - Locked

                return await next(context);
            });
    }

    private static void RegisterAsyncLockerEndpoint_LockAsync_NoPooling(WebApplication app)
    {
        var lockId = Guid.NewGuid();
        var locker = new AsyncKeyedLocker<Guid>(options => options.PoolSize = 0);
        var protectedList = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/async-locker-lock-async-no-pooling", (Request request) => PopOrPush(request, protectedList))
            .AddEndpointFilter(async (context, next) =>
            {
                using var @lock = await locker.LockOrNullAsync(lockId, 0);

                if (@lock == null) return Results.StatusCode(423); // 423 - Locked

                return await next(context);
            });
    }

    private static void RegisterNativeLock(WebApplication app)
    {
        var locker = new Lock();
        var protectedList = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/native-lock", (Request request) => PopOrPush(request, protectedList))
            .AddEndpointFilter(async (context, next) =>
            {
                if (!locker.TryEnter()) return Results.StatusCode(423); // 423 - Locked

                try
                {
                    return await next(context);
                }
                finally
                {
                    locker.Exit();
                }
            });
    }

    private static IResult PopOrPush(Request request, List<int> protectedSyncState)
    {
        if (request.IsPush)
        {
            foreach (var value in protectedSyncState)
            {
                if (value == request.Value) return Results.NoContent();
            }

            protectedSyncState.Add(request.Value);
        }
        else
        {
            var idx = 0;
            foreach (var value in protectedSyncState)
            {
                if (value == request.Value)
                {
                    protectedSyncState.RemoveAt(idx);
                    return Results.NoContent();
                }

                idx++;
            }
        }

        return Results.NoContent();
    }
}
