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
    public class CreditMemoTrackingController : BaseController
    {
        public ICreditMemoTrackingRecord _CreditMemoTrackingRecord { get; }
        ActiveDirectoryService _activeDirectoryService { get; }

        public CreditMemoTrackingController(ICreditMemoTrackingRecord _creditMemoTrackingRecord, ActiveDirectoryService activeDirectoryService)        
        {
            _CreditMemoTrackingRecord = _creditMemoTrackingRecord;
            _activeDirectoryService = activeDirectoryService;
        }

        [HttpGet]
        public IActionResult GetCreditMemoTrackingRecord()
        {
            var data = _CreditMemoTrackingRecord.GetCreditMemoTrackingRecord();

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpGet]
        [Route("{CMRequestID}")]
        public IActionResult GetRootCauseInvestigationByCMRequestID(int CMRequestID)
        {
            var data = _CreditMemoTrackingRecord.GetRootCauseInvestigationByCMRequestID(CMRequestID);
            for (int k = 0; k < data.Count; k++)
            {
                data[k].ProfilePic = _activeDirectoryService.GetUserProfileImage(data[k].CreatedBy);
            }

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveRootCauseInvestigationDetail(RootCauseInvestigation rootCauseInvestigation)
        {
            var saveRootCauseInvestigationDetail = Newtonsoft.Json.JsonConvert.SerializeObject(rootCauseInvestigation);

            if (!Convert.IsDBNull(rootCauseInvestigation.DepartmentID)
                && rootCauseInvestigation.DepartmentID > 0
                && !Convert.IsDBNull(rootCauseInvestigation.UserID)
                && rootCauseInvestigation.UserID > 0
                && !Convert.IsDBNull(rootCauseInvestigation.CMRequestID)
                && rootCauseInvestigation.CMRequestID > 0)
            {
                //var data = _CreditMemoTrackingRecord.SaveRootCauseInvestigationDetail(rootCauseInvestigation);
                var data = _CreditMemoTrackingRecord.SaveRootCauseInvestigationDetail_JSON(saveRootCauseInvestigationDetail);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                return Ok(data);
            }
            else
            {

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(rootCauseInvestigation);
            }

        }
        [HttpGet]
        [Route("{CMRequestID}")]
        public IActionResult GetPlantResponseByCMRequestID(int CMRequestID)
        {
            //var data = _CreditMemoTrackingRecord.GetRootCauseDetailsByCMRequestID(CMRequestID, true);
            var data = _CreditMemoTrackingRecord.GetPlantResponseByCMRequestID(CMRequestID, true);
            for (int k = 0; k < data.Count; k++)
            {
                data[k].ProfilePic = _activeDirectoryService.GetUserProfileImage(data[k].CreatedBy);
            }
            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
        [HttpGet]
        [Route("{CMRequestID}")]
        public IActionResult GetRootCauseByCMRequestID(int CMRequestID)
        {
            var data = _CreditMemoTrackingRecord.GetRootCauseDetailsByCMRequestID(CMRequestID, false);
            for (int k = 0; k < data.Count; k++)
            {
                data[k].ProfilePic = _activeDirectoryService.GetUserProfileImage(data[k].CreatedBy);
            }
            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

    }
}