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
    public class CreditMemoApprovalStatusController : BaseController
    {
        public ICreditMemoApprovalStatus _CreditMemoApprovalStatus { get; }

        public CreditMemoApprovalStatusController(ICreditMemoApprovalStatus _creditMemoApprovalStatus)
        {
            _CreditMemoApprovalStatus = _creditMemoApprovalStatus;
        }

        [HttpGet]
        public IActionResult GetCreditMemoApprovalStatus()
        {
            var data = new JSONConvert<List<CreditMemoApprovalStatus>>().DeserializeObject(_CreditMemoApprovalStatus.GetCreditMemoApprovalStatus());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}