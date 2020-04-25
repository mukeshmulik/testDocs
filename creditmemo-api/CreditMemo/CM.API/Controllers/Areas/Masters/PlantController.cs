using CM.Common;
using CM.Contract.BusinessContract;
using CM.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static CM.Common.Constants;

namespace CM.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlantController : BaseController
    {
        public IPlant _Plant { get; }
        public PlantController(IPlant _plant)
        {
            _Plant = _plant;
        }

        [HttpGet]
        public IActionResult GetAllPlant()
        {
            var data = new JSONConvert<List<Plant>>().DeserializeObject(_Plant.GetAllPlant());

            RouteData.Values.Add(MessageConstants.ReturnMessage, MessageConstants.DataFetched);
            return Ok(data);
        }
    }
}