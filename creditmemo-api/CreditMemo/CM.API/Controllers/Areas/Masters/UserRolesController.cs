using CM.API.Controllers;
using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static CM.Common.Constants;

namespace CreditMemo.Controllers.Areas.Masters
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserRolesController : BaseController
    {
        public IUserRolesService _UserRolesService { get; }

        public UserRolesController(IUserRolesService _userRolesService)
        {
            _UserRolesService = _userRolesService;
        }
        
        [HttpGet]
        public IActionResult GetUserRolesList()
        {
            var data = new JSONConvert<List<UserRoles>>().DeserializeObject(_UserRolesService.GetAllList());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}
