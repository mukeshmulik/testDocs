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
    public class CreditApprovalLevelController : BaseController
    {
        public ICreditApprovalLevel _CreditApprovalLevel { get; }

        public CreditApprovalLevelController(ICreditApprovalLevel _creditApprovalLevel)
        {
            _CreditApprovalLevel = _creditApprovalLevel;
        }

        [HttpGet]
        public IActionResult GetAllCreditApprovalLevel()
        {
            var data = new JSONConvert<List<CreditApprovalLevel>>().DeserializeObject(_CreditApprovalLevel.GetAllCreditApprovalLevel());
            

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}