using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static CM.Common.Constants;

namespace CM.API.Controllers.Areas.Masters
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CreditMemoReasonController : BaseController
    {
        public ICreditMemoReason _CreditMemoReason { get; }

        public CreditMemoReasonController(ICreditMemoReason _creditMemoReason)
        {
            _CreditMemoReason = _creditMemoReason;
        }

        [HttpGet]
        public IActionResult GetCreditMemoReason()
        {
            var data = new JSONConvert<List<Reason>>().DeserializeObject(_CreditMemoReason.GetCreditMemoReason());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveCreditMemoReasonAndErrorCode(ReasonErrorCode reasonErrorCode)
        {
            var saveCreditMemoReasonAndErrorCode = Newtonsoft.Json.JsonConvert.SerializeObject(reasonErrorCode);

            if (!Convert.IsDBNull(reasonErrorCode) && reasonErrorCode != null)
            {
                var data = _CreditMemoReason.SaveCreditMemoReasonAndErrorCode_JSON(saveCreditMemoReasonAndErrorCode);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(reasonErrorCode);
            }

        }

        [HttpPost]
        public IActionResult DeleteCreditMemoReasonAndErrorCode(ReasonErrorCode reasonErrorCode)
        {
            var saveCreditMemoReasonAndErrorCode = Newtonsoft.Json.JsonConvert.SerializeObject(reasonErrorCode);

            if (!Convert.IsDBNull(reasonErrorCode) && reasonErrorCode != null)
            {
                var data = _CreditMemoReason.DeleteCreditMemoReasonAndErrorCode_JSON(saveCreditMemoReasonAndErrorCode);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(reasonErrorCode);
            }

        }
    }
}