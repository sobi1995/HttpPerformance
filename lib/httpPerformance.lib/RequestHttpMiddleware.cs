using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace httpPerformance.lib
{
 

    public class RequestHttpMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly IDataStore _storeProvider;

        public RequestHttpMiddleware(RequestDelegate next, IDataStore storeProvider)
        {
            _next = next;
            _storeProvider = storeProvider;
        }

        // Name of the Response Header, Custom Headers starts with "X-"  
        private const string RESPONSE_HEADER_RESPONSE_TIME = "X-Response-Time-ms";
        // Handle to the next Middleware in the pipeline  
      
       
        public Task InvokeAsync(HttpContext context)
        {
            // Start the Timer using Stopwatch
            var dateTimeProcess = new DateTime();
            dateTimeProcess = DateTime.Now;
            var watch = new Stopwatch();
           
            watch.Start();
            context.Response.OnStarting(() =>
            {
                // Stop the timer information and calculate the time   
                watch.Stop();
                var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;
                // Add the Response time information in the Response headers.   
                context.Response.Headers[RESPONSE_HEADER_RESPONSE_TIME] = responseTimeForCompleteRequest.ToString();

                var httpPerformanceModel = new httpPerformanceModel() { 
                ElapsedMilliseconds= watch.ElapsedMilliseconds.ToString(),
                Elapsed=watch.Elapsed ,
                ElapsedTicks=watch.ElapsedTicks.ToString(),
                Start=dateTimeProcess,
                Stop=DateTime.Now

                };
                 _storeProvider.SaveAsync(httpPerformanceModel);
                return Task.CompletedTask;
            });
            // Call the next delegate/middleware in the pipeline   
            return this._next(context);
        }
    }

}
