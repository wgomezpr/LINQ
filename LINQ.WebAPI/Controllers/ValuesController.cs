using Microsoft.AspNetCore.Mvc;

namespace LINQ.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World!!!";
        }
    }
}