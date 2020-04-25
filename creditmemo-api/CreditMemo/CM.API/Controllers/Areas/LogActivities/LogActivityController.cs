using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static CM.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using CM.API.Controllers;

namespace CreditMemo.Controllers.Areas.LogActivities
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LogActivityController : BaseController
    {
        public ILogActivityService _LogActivityService { get; }

        public LogActivityController(ILogActivityService _logActivityService)
        {
            _LogActivityService = _logActivityService;
        }

        [HttpGet]
        [Route("{UserID}")]
        public IActionResult GetLogActivityList(int UserID)
        {
            var data = new JSONConvert<List<LogActivity>>().DeserializeObject(_LogActivityService.GetAllLogActivityList(UserID));
            

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveLogActivity(LogActivity LogActivity)
        {
            var data = _LogActivityService.SaveLogActivity(LogActivity);
            
            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}
