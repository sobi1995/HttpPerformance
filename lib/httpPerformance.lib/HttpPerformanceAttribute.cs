 
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace hppt_lib
//{
//    public class HttpPerformanceAttribute : ActionFilterAttribute
//    {
//        Stopwatch stopWatch;
//        public override void OnActionExecuting(ActionExecutingContext filterContext)
//        {
//            stopWatch = new Stopwatch();
//            stopWatch.Start();
//        }

//        public override void OnResultExecuted(ResultExecutedContext filterContext)
//        {
//            stopWatch.Stop();
//            Log(filterContext.RouteData, stopWatch.ElapsedMilliseconds);
//        }

//        private void Log(RouteData routeData, long time)
//        {
//            var controllerName = routeData.Values["controller"];
//            var actionName = routeData.Values["action"];
//            ElapsedTime.InsertEntity(time, controllerName + "." + actionName);
//        }
//    }