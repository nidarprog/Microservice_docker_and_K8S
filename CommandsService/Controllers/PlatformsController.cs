using Microsoft.AspNetCore.Mvc;

namespace CommadsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {        
        public PlatformsController()
        {
          
        }

        [HttpPost]
        public ActionResult TestboundConnection()
        {
            Console.WriteLine("--> Inbound POST # command Service");
            return Ok("Inbound test from platforms controller");
        }
        
    }
}