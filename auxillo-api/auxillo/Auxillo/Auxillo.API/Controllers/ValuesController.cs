using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Auxillo.API.Filters;
using Auxillo.Contract.BusinessContract;
using Auxillo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auxillo.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[ServiceFilter(typeof(ResponseFilterAttribute))]
    public class ValuesController : ControllerBase
    {
        public ITestUserService _TestUserService { get; }

        public ValuesController(ITestUserService _testUserService)
        {
            _TestUserService = _testUserService;
        }

        [HttpGet]
        public ActionResult<string> GetData()
        {
            var data = _TestUserService.Get();
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);

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
