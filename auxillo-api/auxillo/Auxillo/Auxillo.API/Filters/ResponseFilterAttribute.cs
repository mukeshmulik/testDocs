//using Auxillo.Common;
//using Auxillo.Contract.BusinessContract;
//using Auxillo.Model;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Newtonsoft.Json;
//using System.IO;
//using static Auxillo.Common.Constants;

//namespace Auxillo.API.Filters
//{
//    public class ResponseFilterAttribute : IActionFilter
//    {

//        public ResponseFilterAttribute(IHttpContextAccessor accessor, ILogActivityService logActivityService, IHostingEnvironment hostingEnvironment)
//        {
//            Accessor = accessor;
//            LogActivityService = logActivityService;
//            HostingEnvironment = hostingEnvironment;
//        }
//        public Stream RequestStream { get; set; }
//        public IHttpContextAccessor Accessor { get; }
//        public ILogActivityService LogActivityService { get; }
//        public IHostingEnvironment HostingEnvironment { get; }
//        public void OnActionExecuting(ActionExecutingContext context)
//        {
//            string UserGlobalID = Accessor.HttpContext.User.Identity.Name == null ? "" : Accessor.HttpContext.User.Identity.Name;

//            string schema = (context.ActionArguments.Count > 0) ? JsonConvert.SerializeObject(context.ActionArguments) : string.Empty;
//            //string[] authorizationToken;
//            //context.HttpContext.Request.Headers.TryGetValue("contentType", out authorizationToken);
//            LogActivity logact = new LogActivity
//            {
//                Data = schema,
//                LoginGUID = context.HttpContext.Request.Headers["loginGUID"].ToString(),
//                SourceDetails = string.Empty,
//                URL = "Request:" + context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"],
//                GlobalID = UserGlobalID
//            };
//            LogActivityService.SaveLogActivity(logact);

//            //Write Log to text File
//            // LogActivityService.WriteLogActivity("[" + UserGID + "][Request][" + context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"] + "]" + schema, Accessor.HttpContext.Connection.RemoteIpAddress.ToString(), Environment.CurrentDirectory + "\\Log");
//        }
//        public void OnActionExecuted(ActionExecutedContext context)
//        {
//            string UserGlobalID = Accessor.HttpContext.User.Identity.Name == null ? "" : Accessor.HttpContext.User.Identity.Name;
//            if (!context.ExceptionHandled && context.Exception == null)
//            {
//                var result = new JsonResult(new ResponseMessage().GetMessage(context.Result, context.RouteData.Values[MessageConstants.ReturnMessage].ToString(), "", true));
//                LogActivity logact = new LogActivity
//                {
//                    Data = JsonConvert.SerializeObject(result),
//                    LoginGUID = context.HttpContext.Request.Headers["loginGUID"].ToString(),
//                    SourceDetails = string.Empty,
//                    URL = "Response:" + context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"],
//                    GlobalID = UserGlobalID
//                };
//                LogActivityService.SaveLogActivity(logact);
//                context.Result = result;

//                //Write Log to text File
//                //LogActivityService.WriteLogActivity("[" + UserGID + "][Response][" + context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"] + "]" + JsonConvert.SerializeObject(context.Result), Accessor.HttpContext.Connection.RemoteIpAddress.ToString(), Environment.CurrentDirectory + "\\Log");
//            }
//        }




//    }
//}
