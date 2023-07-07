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

        [HttpGet("/[action]")]
        public IActionResult MakeBeepSound(int duration = 1)
        {
            Main.MakeBeepSound(duration * 1000);
            return Ok($"Beep sound with duration: {duration}s created.");
        }
    }
}
