using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using static CM.Common.Constants;

namespace CM.API.Controllers.Areas.Users
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManageUserController : BaseController
    {
        public IManageUser _ManageUser { get; }

        ActiveDirectoryService _ActiveDirectoryService { get; }

        public ManageUserController(IManageUser _manageUser, ActiveDirectoryService activeDirectoryService)
        {
            _ManageUser = _manageUser;
            _ActiveDirectoryService = activeDirectoryService;
        }

        [HttpGet]
        public IActionResult GetAllRequest()
        {
            var data = _ManageUser.GetAllRequest();

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetAllPendingRequest()
        {
            var data = _ManageUser.GetAllPendingRequest();

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveUserDetail(UserDetail userDetail)
        {
            var saveUserDetail = Newtonsoft.Json.JsonConvert.SerializeObject(userDetail);
            if (userDetail != null && userDetail.GlobalID != "" && userDetail.DepartmentID > 0)
            {
                //var Check = _ManageUser.CheckUserDetail(userDetail);
                var Check = _ManageUser.CheckUserDetail_JSON(saveUserDetail);
                if (Check != null)
                {
                    RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.UserAlreadyExist);
                    return Ok(Check);
                }
                else
                {
                    //var data = _ManageUser.SaveUserDetail(userDetail);
                    var data = _ManageUser.SaveUserDetail_JSON(saveUserDetail);
                    RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataSaved);
                    return Ok(data);
                }
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(userDetail);
            }
        }

        [HttpPost]
        public IActionResult DeleteUserDetail(UserDetail userDetail)
        {
            //if (userDetail != null && userDetail.UserID > 0 && userDetail.DepartmentID > 0)
            if (userDetail != null)
            {
                //var data = _ManageUser.DeleteUserDetail(userDetail);
                userDetail.Loggedin_GlobalID = User.Identity.Name;
                var deleteUserDetail = Newtonsoft.Json.JsonConvert.SerializeObject(userDetail);
                var data = _ManageUser.DeleteUserDetail_JSON(deleteUserDetail);
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataDeleted);
                return Ok(userDetail);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(userDetail);
            }
        }

        [HttpPost]
        public IActionResult ApproveUserPendingRequest(UserDetail userDetail)
        {
            var approveUserPendingRequest = Newtonsoft.Json.JsonConvert.SerializeObject(userDetail);
            if (userDetail != null && userDetail.GlobalID != "")
            {
                userDetail.Loggedin_GlobalID = User.Identity.Name;
                //var data = _ManageUser.ApproveUserPendingRequest(userDetail);
                var data = _ManageUser.ApproveUserPendingRequest_JSON(approveUserPendingRequest);
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.UserApproved);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(userDetail);
            }
        }
        [HttpPost]
        public IActionResult JsonRequestTest(Newtonsoft.Json.Linq.JObject userDetail)
        {
            var data = _ManageUser.uspSaveUserAccessRequest_JSON(userDetail.ToString());
            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.UserApproved);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult RejectUserPendingRequest(UserDetail userDetail)
        {
            var rejectUserPendingRequest = Newtonsoft.Json.JsonConvert.SerializeObject(userDetail);
            if (userDetail != null && userDetail.GlobalID != "")
            {
                //var data = _ManageUser.RejectUserPendingRequest(userDetail);
                var data = _ManageUser.RejectUserPendingRequest_JSON(rejectUserPendingRequest);
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.UserRejected);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.InvalidData);
                return Ok(userDetail);
            }
        }
    }
}
