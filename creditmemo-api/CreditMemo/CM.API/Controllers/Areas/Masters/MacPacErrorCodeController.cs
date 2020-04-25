using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static CM.Common.Constants;

namespace CM.API.Controllers.Areas.Masters
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MacPacErrorCodeController : BaseController
    {
        public IMacPacErrorCode _MacPacErrorCode { get; }

        public MacPacErrorCodeController(IMacPacErrorCode _macPacErrorCode)
        {
            _MacPacErrorCode = _macPacErrorCode;
        }

        [HttpGet]
        public IActionResult GetMacPacErrorCodes()
        {
            var data = new JSONConvert<List<MacPacErrorCode>>().DeserializeObject(_MacPacErrorCode.GetMacPacErrorCodes());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}