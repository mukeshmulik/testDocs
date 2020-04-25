using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using static CM.Common.Constants;

namespace CM.API.Controllers.Areas.CreditMemo
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CreditMemoAmountDivisionDetailController : BaseController
    {
        public ICreditMemoAmountDivisionDetail _CreditMemoAmountDivisionDetail { get; }
        ActiveDirectoryService _activeDirectoryService { get; }
        public CreditMemoAmountDivisionDetailController(ICreditMemoAmountDivisionDetail _creditMemoAmountDivisionDetail, ActiveDirectoryService activeDirectoryService)
        {
            _CreditMemoAmountDivisionDetail = _creditMemoAmountDivisionDetail;
            _activeDirectoryService = activeDirectoryService;
        }

        [HttpGet]
        [Route("{CMRequestID}")]
        public IActionResult GetCreditMemoAmountDivisionDetailByCMRequestID(int CMRequestID)
        {
            var data = _CreditMemoAmountDivisionDetail.GetCreditMemoAmountDivisionDetailByCMRequestID(CMRequestID);

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveCreditMemoAmountDivisionDetail(CreditMemoAmountDivisionDetail creditMemoAmountDivisionDetail)
        {
            var saveCreditMemoAmountDivisionDetail = Newtonsoft.Json.JsonConvert.SerializeObject(creditMemoAmountDivisionDetail);

            if (!Convert.IsDBNull(creditMemoAmountDivisionDetail.DepartmentID)
                && creditMemoAmountDivisionDetail.DepartmentID > 0
                && !Convert.IsDBNull(creditMemoAmountDivisionDetail.CMRequestID)
                && creditMemoAmountDivisionDetail.CMRequestID > 0)
            {
                var data = _CreditMemoAmountDivisionDetail.SaveCreditMemoAmountDivisionDetail_JSON(saveCreditMemoAmountDivisionDetail);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(creditMemoAmountDivisionDetail);
            }
        }
    }
}