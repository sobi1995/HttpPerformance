using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Simple
{
    public class HttpPerformanceAttribute : ActionFilterAttribute
    {
        Stopwatch stopWatch;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            stopWatch.Stop();
 
        }

        private void Log(RouteData routeData, long time)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
     
        }

    }
}
