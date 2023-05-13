using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entekhab.Endpoints.WebApi.Controllers
{
    [Route("Homes")]
    [ApiController]
    public class HomeController : ControllerBase
    {
   
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok("test");
        }
 
    }
}
