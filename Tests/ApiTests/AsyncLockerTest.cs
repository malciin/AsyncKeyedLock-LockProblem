using System.Diagnostics;
using System.Net.Http.Json;
using Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTests;

public class AsyncLockerTest
{
    private WebApplication webApp;
    private string serverUrl;
    private int totalRequests = 0;
    private int successRequests = 0;

    [SetUp]
    public async Task Setup()
    {
        webApp = Api.Program.CreateWebApp(["--urls", "http://127.0.0.1:0"]);
        await webApp.StartAsync();

        serverUrl = webApp.Services.GetRequiredService<IServer>()
            .Features
            .Get<IServerAddressesFeature>()!
            .Addresses
            .Single();
    }

    [TearDown]
    public async Task TearDown()
    {
        await webApp.StopAsync();
        await webApp.DisposeAsync();

        totalRequests = successRequests = 0;
    }

    [Test]
    public async Task Cannon_AsyncLocker()
    {
        var endpointUrl = serverUrl + "/async-locker";

        try
        {
            await Task.WhenAll(Enumerable.Range(0, 100).Select(x => Cannon(endpointUrl, TimeSpan.FromSeconds(30))));
        }
        finally
        {
            TestContext.Out.WriteLine($"All requests: {totalRequests}");
            TestContext.Out.WriteLine($"Success: {successRequests}");
        }
    }

    [Test]
    public async Task Cannon_AsyncLocker_LockAsync()
    {
        var endpointUrl = serverUrl + "/async-locker-lock-async";

        try
        {
            await Task.WhenAll(Enumerable.Range(0, 100).Select(x => Cannon(endpointUrl, TimeSpan.FromSeconds(30))));
        }
        finally
        {
            TestContext.Out.WriteLine($"All requests: {totalRequests}");
            TestContext.Out.WriteLine($"Success: {successRequests}");
        }
    }

    [Test]
    public async Task Cannon_NativeLocker()
    {
        var endpointUrl = serverUrl + "/native-lock";

        try
        {
            await Task.WhenAll(Enumerable.Range(0, 100).Select(x => Cannon(endpointUrl, TimeSpan.FromSeconds(30))));
        }
        finally
        {
            TestContext.Out.WriteLine($"All requests: {totalRequests}");
            TestContext.Out.WriteLine($"Success: {successRequests}");
        }
    }

    private async Task Cannon(
        string url,
        TimeSpan duration)
    {
        using var client = new HttpClient();
        var stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed < duration)
        {
            var value = Random.Shared.Next(0, 100);
            var isPop = Random.Shared.Next(0, 2) >= 1;

            using var response = await client.PostAsJsonAsync(url, new Request(value, isPop));
            Interlocked.Increment(ref totalRequests);

            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                Interlocked.Increment(ref successRequests);
            }
            else if (response.StatusCode != System.Net.HttpStatusCode.Locked)
            {
                throw new HttpRequestException($"Unexpected status code: {response.StatusCode}");
            }
        }
    }
}
