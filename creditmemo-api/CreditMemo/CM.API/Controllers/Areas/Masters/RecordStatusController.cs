using CM.API.Controllers;
using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static CM.Common.Constants;

namespace CreditMemo.Controllers.Areas.Masters
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecordStatusController : BaseController
    {
        public IRecordStatusService _RecordStatusService { get; }

        public RecordStatusController(IRecordStatusService _recordStatusService)
        {
            _RecordStatusService = _recordStatusService;
        }

        [HttpGet]
        public IActionResult GetRecordStatusList()
        {
            var data = new JSONConvert<List<RecordStatus>>().DeserializeObject(_RecordStatusService.GetAllList());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}
