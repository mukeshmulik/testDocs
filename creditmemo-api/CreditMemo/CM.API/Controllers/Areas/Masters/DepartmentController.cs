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
    public class DepartmentController : BaseController
    {
        public IDepartment _Department { get; }

        public DepartmentController(IDepartment _department)
        {
            _Department = _department;
        }

        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var data = new JSONConvert<List<Department>>().DeserializeObject(_Department.GetAllDepartments());
            
            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}