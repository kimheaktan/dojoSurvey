using Microsoft.AspNetCore.Mvc;

namespace dojoSurvery.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            return View();
        }

        
    }
}