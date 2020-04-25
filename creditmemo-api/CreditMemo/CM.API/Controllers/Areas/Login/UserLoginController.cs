using CM.API.Filters;
using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using static CM.Common.Constants;

namespace CM.API.Controllers.Areas.Login
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserLoginController : BaseController
    {
        public IManageUser _ManageUser { get; }
        ActiveDirectoryService _ActiveDirectoryService { get; }

        public UserLoginController(IManageUser _manageUser, ActiveDirectoryService activeDirectoryService)
        {
            _ManageUser = _manageUser;
            _ActiveDirectoryService = activeDirectoryService;
        }

        [HttpGet]
        [Route("{GlobalID}")]
        public IActionResult GetUserADDetails(string GlobalID)
        {
            var data = _ActiveDirectoryService.GetUserByGlobalId(GlobalID);

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }

        [HttpGet]
        [Route("{GlobalID}")]
        public IActionResult GetUserLogin(string GlobalID)
        {
           
            var data = new JSONConvert<UserInfo>().DeserializeObject(_ManageUser.GetUserDetailsByGlobalID(GlobalID));
            if (data != null)
            {
                data.LoginGUID = Guid.NewGuid().ToString();
                data.ProfileImage = _ActiveDirectoryService.GetUserProfileImage(GlobalID);

                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
                return Ok(data);
            }
            else
            {
                RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.NoData);
                return Ok(data);
            }

        }

    }
}