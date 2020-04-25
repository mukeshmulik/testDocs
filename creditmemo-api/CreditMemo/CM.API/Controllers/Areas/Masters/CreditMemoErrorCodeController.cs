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
    public class CreditMemoErrorCodeController : BaseController
    {
        public ICreditMemoErrorCode _CreditMemoErrorCode { get; }

        public CreditMemoErrorCodeController(ICreditMemoErrorCode _creditMemoErrorCode)
        {
            _CreditMemoErrorCode = _creditMemoErrorCode;
        }

        [HttpGet]
        [Route("{ReasonID}")]
        public IActionResult GetCreditErrorCodeByReasonID(int ReasonID)
        {
            var data = _CreditMemoErrorCode.GetCreditErrorCodeByReasonID(ReasonID);

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}