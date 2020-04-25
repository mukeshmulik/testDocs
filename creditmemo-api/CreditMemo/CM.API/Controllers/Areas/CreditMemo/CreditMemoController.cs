using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using static CM.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using System;

namespace CM.API.Controllers.Areas.CreditMemo
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CreditMemoInfoController : BaseController
    {
        public ICreditMemoInfoService _CreditMemo { get; set; }
        public ICreditMemoModelDetailsService _CreditMemoModelDetails { get; set; }
        public ICreditMemoProductDetailsService _CreditMemoProductDetails { get; set; }
        public ICreditMemoAttachmentDetailsService _CreditMemoAttachmentDetails { get; set; }

        public CreditMemoInfoController(ICreditMemoInfoService _creditMemo, ICreditMemoModelDetailsService _creditMemoModelDetails, ICreditMemoProductDetailsService _creditMemoProductDetails, ICreditMemoAttachmentDetailsService _creditMemoAttachmentDetails)
        {
            _CreditMemo = _creditMemo;
            _CreditMemoAttachmentDetails = _creditMemoAttachmentDetails;
            _CreditMemoProductDetails = _creditMemoProductDetails;
            _CreditMemoModelDetails = _creditMemoModelDetails;
        }

        [HttpGet]
        public IActionResult GetAllCreditMemos()
        {
            var data = _CreditMemo.GetAllCreditMemo();

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);

        }

        [HttpGet]
        [Route("{CMRequestID}")]
        public IActionResult GetCreditMemoDetailsByCMRequestID(int CMRequestID)
        {
            var Result = new CreditMemoInfoDetails
            {
                CMRequest = _CreditMemo.GetCreditMemoDetailsByID(CMRequestID),
                AttachmentDetails = _CreditMemoAttachmentDetails.GetAttachmentsByID(CMRequestID),
                ModelDetails = _CreditMemoModelDetails.GetModelDetailsByID(CMRequestID),
                ProductDetails = _CreditMemoProductDetails.GetProductDetailsByID(CMRequestID)
            };

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(Result);
        }

        [HttpPost]
        public IActionResult SaveCreditMemoRequest(CreditMemoApprovalRequest creditMemoApprovalRequest)
        {
            var saveCreditMemoRequest = Newtonsoft.Json.JsonConvert.SerializeObject(creditMemoApprovalRequest);

            if (!Convert.IsDBNull(creditMemoApprovalRequest.CMRequestID)
                && creditMemoApprovalRequest.CMRequestID > 0)
            {                
                var data = _CreditMemo.SaveCreditMemoRequest_JSON(saveCreditMemoRequest);
                if(data.Message == "Success")
                {
                    RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);                    
                }
                else
                {
                    RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.Error);
                }
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(creditMemoApprovalRequest);
            }
        }

        [HttpPost]
        public IActionResult RejectCreditMemoRequest(CreditMemoRejectRequest creditMemoRejectRequest)
        {
            var rejectCreditMemoRequest = Newtonsoft.Json.JsonConvert.SerializeObject(creditMemoRejectRequest);

            if (!Convert.IsDBNull(creditMemoRejectRequest.CMRequestID) && creditMemoRejectRequest.CMRequestID > 0)
            {
                var data = _CreditMemo.RejectCreditMemoRequest_JSON(rejectCreditMemoRequest);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(creditMemoRejectRequest);
            }
        }
    }
}