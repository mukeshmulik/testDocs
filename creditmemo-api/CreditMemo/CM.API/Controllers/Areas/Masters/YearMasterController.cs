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
    public class YearMasterController : BaseController
    {
        public IYearMasterService _YearMasterService { get; }

        public YearMasterController(IYearMasterService _yearMasterService)
        {
            _YearMasterService = _yearMasterService;
        }
        
        [HttpGet]
        public ActionResult<string> GetYearMasterList()
        {
            var data = new JSONConvert<List<YearMaster>>().DeserializeObject(_YearMasterService.GetAllList());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}
