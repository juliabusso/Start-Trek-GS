using Microsoft.AspNetCore.Mvc;

namespace FIAP.CP2.API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                message = "API StartTrek FIAP CP2 funcionando 🚀",
                version = "1.0"
            });
        }
    }
}
