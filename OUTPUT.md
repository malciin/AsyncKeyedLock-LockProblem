```
AsyncLock-Issue> dotnet test
Restore complete (0.4s)
  Api net10.0 succeeded (0.2s) → Api\bin\Debug\net10.0\Api.dll
  ApiTests net10.0 succeeded (0.2s) → Tests\ApiTests\bin\Debug\net10.0\ApiTests.dll
NUnit Adapter 5.0.0.0: Test execution started
Running all tests in C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\bin\Debug\net10.0\ApiTests.dll
   NUnit3TestExecutor discovered 3 of 3 NUnit test cases using Current Discovery mode, Non-Explicit run
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://127.0.0.1:63291
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\bin\Debug\net10.0
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01VQ", Request id "0HNLQM2FU01VQ:00000683": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01V0", Request id "0HNLQM2FU01V0:00000F92": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01UP", Request id "0HNLQM2FU01UP:0000116B": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU020O", Request id "0HNLQM2FU020O:00001B78": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0212", Request id "0HNLQM2FU0212:00001C9E": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01VU", Request id "0HNLQM2FU01VU:00002052": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01V6", Request id "0HNLQM2FU01V6:0000283C": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01US", Request id "0HNLQM2FU01US:00002FCB": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01V9", Request id "0HNLQM2FU01V9:00004BF9": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0202", Request id "0HNLQM2FU0202:00005969": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU020H", Request id "0HNLQM2FU020H:000059C6": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01V3", Request id "0HNLQM2FU01V3:000059E1": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0215", Request id "0HNLQM2FU0215:00005D5E": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01VC", Request id "0HNLQM2FU01VC:00005F1B": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU021O", Request id "0HNLQM2FU021O:00007075": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU021M", Request id "0HNLQM2FU021M:00007047": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01UT", Request id "0HNLQM2FU01UT:00008EE5": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0207", Request id "0HNLQM2FU0207:00008E37": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU020G", Request id "0HNLQM2FU020G:0000AA67": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01VK", Request id "0HNLQM2FU01VK:0000C34E": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU01UN", Request id "0HNLQM2FU01UN:0000CD28": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 27
         at lambda_method22(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 34
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
All requests: 4664386
Success: 1748381
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://127.0.0.1:63424
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\bin\Debug\net10.0
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU022P", Request id "0HNLQM2FU022P:00000EC7": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0242", Request id "0HNLQM2FU0242:000017CB": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU024H", Request id "0HNLQM2FU024H:000017CD": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023D", Request id "0HNLQM2FU023D:00002F99": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023N", Request id "0HNLQM2FU023N:0000304E": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU022E", Request id "0HNLQM2FU022E:00003694": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023H", Request id "0HNLQM2FU023H:00003797": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU022M", Request id "0HNLQM2FU022M:00003E58": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0225", Request id "0HNLQM2FU0225:00004031": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU021U", Request id "0HNLQM2FU021U:00004832": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0234", Request id "0HNLQM2FU0234:00005566": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0231", Request id "0HNLQM2FU0231:00005A6E": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023U", Request id "0HNLQM2FU023U:000066E7": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0223", Request id "0HNLQM2FU0223:0000751B": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023G", Request id "0HNLQM2FU023G:00008B61": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU0229", Request id "0HNLQM2FU0229:000091C8": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023K", Request id "0HNLQM2FU023K:00009B42": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU024E", Request id "0HNLQM2FU024E:00009D62": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023O", Request id "0HNLQM2FU023O:0000A5BA": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU024O", Request id "0HNLQM2FU024O:0000A911": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU021V", Request id "0HNLQM2FU021V:0000B5BF": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023V", Request id "0HNLQM2FU023V:0000C58C": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 76
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
fail: Microsoft.AspNetCore.Server.Kestrel[13]
      Connection id "0HNLQM2FU023Q", Request id "0HNLQM2FU023Q:0000CE1D": An unhandled exception was thrown by the application.
      System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
         at System.Collections.Generic.List`1.Enumerator.MoveNext()
         at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 86
         at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 41
         at lambda_method63(Closure, EndpointFilterInvocationContext)
         at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line 48
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpContext httpContext, JsonTypeInfo`1 jsonTypeInfo)
         at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.MoveNext()
      --- End of stack trace from previous location ---
         at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
All requests: 5010850
Success: 1859008
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://127.0.0.1:63560
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\bin\Debug\net10.0
All requests: 5294908
Success: 2641088
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...

NUnit Adapter 5.0.0.0: Test execution complete
  ApiTests test net10.0 failed with 2 error(s) (90.7s)
    C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\AsyncLockerTest.cs(109): error TESTERROR:
      Cannon_AsyncLocker (30s 111ms): Error Message: System.Net.Http.HttpRequestException : Unexpected status code: InternalServerError
      Stack Trace:
         at ApiTests.AsyncLockerTest.Cannon(String url, TimeSpan duration) in C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\AsyncLockerTest
      .cs:line 109
         at ApiTests.AsyncLockerTest.Cannon_AsyncLocker() in C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\AsyncLockerTest.cs:line 47
         at NUnit.Framework.Internal.TaskAwaitAdapter.GenericAdapter`1.BlockUntilCompleted()
         at NUnit.Framework.Internal.MessagePumpStrategy.NoMessagePumpStrategy.WaitForCompletion(AwaitAdapter awaiter)
         at NUnit.Framework.Internal.AsyncToSyncAdapter.Await[TResult](TestExecutionContext context, Func`1 invoke)
         at NUnit.Framework.Internal.AsyncToSyncAdapter.Await(TestExecutionContext context, Func`1 invoke)
         at NUnit.Framework.Internal.Commands.TestMethodCommand.RunTestMethod(TestExecutionContext context)
         at NUnit.Framework.Internal.Commands.TestMethodCommand.Execute(TestExecutionContext context)
         at NUnit.Framework.Internal.Commands.BeforeAndAfterTestCommand.<>c__DisplayClass1_0.<Execute>b__0()
         at NUnit.Framework.Internal.Commands.DelegatingTestCommand.RunTestMethodInThreadAbortSafeZone(TestExecutionContext context, Action action)

        Standard Output Messages:
       info: Microsoft.Hosting.Lifetime[14]
             Now listening on: http://127.0.0.1:63291
       info: Microsoft.Hosting.Lifetime[0]
             Application started. Press Ctrl+C to shut down.
       info: Microsoft.Hosting.Lifetime[0]
             Hosting environment: Production
       info: Microsoft.Hosting.Lifetime[0]
             Content root path: C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\bin\Debug\net10.0
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01VQ", Request id "0HNLQM2FU01VQ:00000683": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01V0", Request id "0HNLQM2FU01V0:00000F92": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01UP", Request id "0HNLQM2FU01UP:0000116B": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU020O", Request id "0HNLQM2FU020O:00001B78": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0212", Request id "0HNLQM2FU0212:00001C9E": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01VU", Request id "0HNLQM2FU01VU:00002052": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01V6", Request id "0HNLQM2FU01V6:0000283C": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01US", Request id "0HNLQM2FU01US:00002FCB": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01V9", Request id "0HNLQM2FU01V9:00004BF9": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0202", Request id "0HNLQM2FU0202:00005969": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU020H", Request id "0HNLQM2FU020H:000059C6": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01V3", Request id "0HNLQM2FU01V3:000059E1": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0215", Request id "0HNLQM2FU0215:00005D5E": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01VC", Request id "0HNLQM2FU01VC:00005F1B": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU021O", Request id "0HNLQM2FU021O:00007075": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU021M", Request id "0HNLQM2FU021M:00007047": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01UT", Request id "0HNLQM2FU01UT:00008EE5": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0207", Request id "0HNLQM2FU0207:00008E37": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU020G", Request id "0HNLQM2FU020G:0000AA67": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01VK", Request id "0HNLQM2FU01VK:0000C34E": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU01UN", Request id "0HNLQM2FU01UN:0000CD28": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__0(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 27
                at lambda_method22(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__1>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      34
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       All requests: 4664386
       Success: 1748381
       info: Microsoft.Hosting.Lifetime[0]
             Application is shutting down...
    C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\AsyncLockerTest.cs(109): error TESTERROR:
      Cannon_AsyncLocker_LockAsync (30s 34ms): Error Message: System.Net.Http.HttpRequestException : Unexpected status code: InternalServerError
      Stack Trace:
         at ApiTests.AsyncLockerTest.Cannon(String url, TimeSpan duration) in C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\AsyncLockerTest
      .cs:line 109
         at ApiTests.AsyncLockerTest.Cannon_AsyncLocker_LockAsync() in C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\AsyncLockerTest.cs:lin
      e 63
         at NUnit.Framework.Internal.TaskAwaitAdapter.GenericAdapter`1.BlockUntilCompleted()
         at NUnit.Framework.Internal.MessagePumpStrategy.NoMessagePumpStrategy.WaitForCompletion(AwaitAdapter awaiter)
         at NUnit.Framework.Internal.AsyncToSyncAdapter.Await[TResult](TestExecutionContext context, Func`1 invoke)
         at NUnit.Framework.Internal.AsyncToSyncAdapter.Await(TestExecutionContext context, Func`1 invoke)
         at NUnit.Framework.Internal.Commands.TestMethodCommand.RunTestMethod(TestExecutionContext context)
         at NUnit.Framework.Internal.Commands.TestMethodCommand.Execute(TestExecutionContext context)
         at NUnit.Framework.Internal.Commands.BeforeAndAfterTestCommand.<>c__DisplayClass1_0.<Execute>b__0()
         at NUnit.Framework.Internal.Commands.DelegatingTestCommand.RunTestMethodInThreadAbortSafeZone(TestExecutionContext context, Action action)

        Standard Output Messages:
       info: Microsoft.Hosting.Lifetime[14]
             Now listening on: http://127.0.0.1:63424
       info: Microsoft.Hosting.Lifetime[0]
             Application started. Press Ctrl+C to shut down.
       info: Microsoft.Hosting.Lifetime[0]
             Hosting environment: Production
       info: Microsoft.Hosting.Lifetime[0]
             Content root path: C:\Users\Marcin\Developer\AsyncLock-Issue\Tests\ApiTests\bin\Debug\net10.0
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU022P", Request id "0HNLQM2FU022P:00000EC7": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0242", Request id "0HNLQM2FU0242:000017CB": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU024H", Request id "0HNLQM2FU024H:000017CD": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023D", Request id "0HNLQM2FU023D:00002F99": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023N", Request id "0HNLQM2FU023N:0000304E": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU022E", Request id "0HNLQM2FU022E:00003694": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023H", Request id "0HNLQM2FU023H:00003797": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU022M", Request id "0HNLQM2FU022M:00003E58": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0225", Request id "0HNLQM2FU0225:00004031": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU021U", Request id "0HNLQM2FU021U:00004832": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0234", Request id "0HNLQM2FU0234:00005566": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0231", Request id "0HNLQM2FU0231:00005A6E": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023U", Request id "0HNLQM2FU023U:000066E7": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0223", Request id "0HNLQM2FU0223:0000751B": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023G", Request id "0HNLQM2FU023G:00008B61": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU0229", Request id "0HNLQM2FU0229:000091C8": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023K", Request id "0HNLQM2FU023K:00009B42": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU024E", Request id "0HNLQM2FU024E:00009D62": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023O", Request id "0HNLQM2FU023O:0000A5BA": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU024O", Request id "0HNLQM2FU024O:0000A911": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU021V", Request id "0HNLQM2FU021V:0000B5BF": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023V", Request id "0HNLQM2FU023V:0000C58C": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      76
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       fail: Microsoft.AspNetCore.Server.Kestrel[13]
             Connection id "0HNLQM2FU023Q", Request id "0HNLQM2FU023Q:0000CE1D": An unhandled exception was thrown by the application.
             System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
                at System.Collections.Generic.List`1.Enumerator.MoveNext()
                at Api.Program.PopOrPush(Request request, List`1 protectedSyncState) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      86
                at Api.Program.<>c__DisplayClass1_0.<CreateWebApp>b__2(Request request) in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:li
      ne 41
                at lambda_method63(Closure, EndpointFilterInvocationContext)
                at Api.Program.<>c__DisplayClass1_0.<<CreateWebApp>b__3>d.MoveNext() in C:\Users\Marcin\Developer\AsyncLock-Issue\Api\Program.cs:line
      48
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<ExecuteValueTaskOfObject>g__ExecuteAwaited|130_0(ValueTask`1 valueTask, HttpConte
      xt httpContext, JsonTypeInfo`1 jsonTypeInfo)
                at Microsoft.AspNetCore.Http.RequestDelegateFactory.<>c__DisplayClass102_2.<<HandleRequestBodyAndCompileRequestDelegateForJson>b__2>d.
      MoveNext()
             --- End of stack trace from previous location ---
                at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
       All requests: 5010850
       Success: 1859008
       info: Microsoft.Hosting.Lifetime[0]
             Application is shutting down...

Test summary: total: 3, failed: 2, succeeded: 1, skipped: 0, duration: 90.7s
Build failed with 2 error(s) in 91.8
```