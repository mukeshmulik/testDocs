using CM.API.Controllers;
using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using static CM.Common.Constants;

namespace CreditMemo.Controllers.Areas.Users
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserAccessRequestController : BaseController
    {
        public IUserAccessRequestService _UserAccessRequestService { get; }
        ActiveDirectoryService _ActiveDirectoryService { get; }

        public UserAccessRequestController(IUserAccessRequestService _userAccessRequestService, ActiveDirectoryService activeDirectoryService)
        {
            _UserAccessRequestService = _userAccessRequestService;
            _ActiveDirectoryService = activeDirectoryService;
        }

        [HttpGet]
        public IActionResult GetUserAccessRequestList()
        {
            var data = _UserAccessRequestService.GetAllUserAccessRequestList();

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveAccessRequest(UserAccessRequest userAccessRequest)
        {
            var saveAccessRequest = Newtonsoft.Json.JsonConvert.SerializeObject(userAccessRequest);

            if (userAccessRequest != null && !string.IsNullOrEmpty(userAccessRequest.GlobalID))
            {
                //var Check = _UserAccessRequestService.CheckUserAccessRequest(userAccessRequest);
                //var Check = _UserAccessRequestService.CheckUserAccessRequest_JSON(saveAccessRequest);
                //if (Check != null)
                //{
                //    //return Ok(new ResponseMessage().GetMessage(Check, "Already in Queue", null, false));
                //    RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.UserInQueue);
                //    return Ok(Check);
                //}
                //else
                //{

                var UserDataFromAD = _ActiveDirectoryService.GetUserByGlobalId(userAccessRequest.GlobalID);
                userAccessRequest.Email = UserDataFromAD.Email;
                userAccessRequest.RequesterEmail = UserDataFromAD.Email;
                userAccessRequest.UserName = UserDataFromAD.FullName;
                userAccessRequest.ContactNo = UserDataFromAD.Mobile;

                //var data = _UserAccessRequestService.SaveUserAccessRequest(userAccessRequest);
                var data = _UserAccessRequestService.SaveUserAccessRequest_JSON(saveAccessRequest);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                return Ok(data);
                //}
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(userAccessRequest);
            }
        }
    }
}
