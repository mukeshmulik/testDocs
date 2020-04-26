//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Auxillo.Common;
//using Auxillo.Contract.BusinessContract;
//using Auxillo.Model;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Newtonsoft.Json;
//using static Auxillo.Common.Constants;

//namespace Auxillo.API.Filters
//{
//    public class ExceptionFilterAttribute : IExceptionFilter
//    {
//        public ExceptionFilterAttribute(IHttpContextAccessor accessor, ILogErrorService logErrorService, IHostingEnvironment hostingEnvironment)
//        {
//            Accessor = accessor;
//            LogErrorService = logErrorService;
//            HostingEnvironment = hostingEnvironment;
//        }

//        public IHttpContextAccessor Accessor { get; }
//        public ILogErrorService LogErrorService { get; }
//        public IHostingEnvironment HostingEnvironment { get; }

//        public void OnException(ExceptionContext context)
//        {
//            if (!context.ExceptionHandled && context.Exception != null)
//            {
//                string UserGlobalID = Accessor.HttpContext.User.Identity.Name == null ? "" : Accessor.HttpContext.User.Identity.Name;
//                var result= new JsonResult(new ResponseMessage().GetMessage("Error while processing your request. please try after some time.", context.Exception.Message, MessageConstants.Error, false));

//                LogError logError = new LogError
//                {
//                    CreatedBy = UserGlobalID,
//                    ErrorMessage = context.Exception.Message,
//                    Source = context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"],
//                    FunctionName = "",
//                    InnerException = context.Exception.InnerException==null?"": context.Exception.InnerException.ToString(),
//                    RecordStatusId = 1,
//                    StackTrace = context.Exception.StackTrace.ToString()
                    
//                };
//                LogErrorService.SaveLogError(logError);
//                context.Result = result;
//                //LogActivityService.WriteLogActivity("[" + UserGID + "][Exception][" + context.RouteData.Values["controller"] + "/" + context.RouteData.Values["action"] + "]" + context.Exception.Message, Accessor.HttpContext.Connection.RemoteIpAddress.ToString(), Environment.CurrentDirectory + "\\Log");
//            }
//        }
//    }
//}
