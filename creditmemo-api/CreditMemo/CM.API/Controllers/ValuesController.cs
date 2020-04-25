using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CM.API.Filters;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CreditMemo.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ServiceFilter(typeof(ResponseFilterAttribute))]
    public class ValuesController : ControllerBase
    {
        public ITestUserService _TestUserService { get; }

        public ValuesController(ITestUserService _testUserService)
        {
            _TestUserService = _testUserService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var data = _TestUserService.GetNameByList(1);
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
            
        }
        [HttpPost]
        public ActionResult<string> Post(TestUser testUserService)
        {
            var data = _TestUserService.GetNameByList(1);
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);

        }


    }
}
