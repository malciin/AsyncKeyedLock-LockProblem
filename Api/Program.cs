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

        var lockId = Guid.NewGuid();
        var locker = new AsyncKeyedLocker<Guid>();
        var asyncLockerList = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/async-locker", (Request request) => PopOrPush(request, asyncLockerList))
            .AddEndpointFilter(async (context, next) =>
            {
                using var @lock = locker.LockOrNull(lockId, 0);

                if (@lock == null) return Results.StatusCode(423); // 423 - Locked

                return await next(context);
            });

        var lockId2 = Guid.NewGuid();
        var locker2 = new AsyncKeyedLocker<Guid>();
        var asyncLockerList2 = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/async-locker-lock-async", (Request request) => PopOrPush(request, asyncLockerList2))
            .AddEndpointFilter(async (context, next) =>
            {
                using var @lock = await locker.LockOrNullAsync(lockId, 0);

                if (@lock == null) return Results.StatusCode(423); // 423 - Locked

                return await next(context);
            });

        var nativeLock = new Lock();
        var nativeLockList = Enumerable.Range(0, 100).ToList(); // shared state that needs protection
        app
            .MapPost("/native-lock", (Request request) => PopOrPush(request, nativeLockList))
            .AddEndpointFilter(async (context, next) =>
            {
                if (!nativeLock.TryEnter()) return Results.StatusCode(423); // 423 - Locked

                try
                {
                    return await next(context);
                }
                finally
                {
                    nativeLock.Exit();
                }
            });

        return app;
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
