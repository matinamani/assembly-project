using HardwareChange;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HardwareController : Controller
    {
        private Main Main;
        public HardwareController()
        {
            Main = new Main();
        }
        
        [HttpGet("/[controller]/[action]")]
        public IActionResult MakeBeepSound(int duration)
        {
            Main.MakeBeepSound(duration * 1000);
            return Ok($"Beep sound with duration: {duration}s created.");
        }
    }
}
