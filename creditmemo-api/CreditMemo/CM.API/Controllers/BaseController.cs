using CM.API.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CM.API.Controllers
{
    [ServiceFilter(typeof(ResponseFilterAttribute))]
    [ServiceFilter(typeof(ExceptionFilterAttribute))]
  
    public class BaseController:ControllerBase
    {
    }
}