using Microsoft.AspNetCore.Mvc;

namespace dojoSurvery.Controllers
{
    public class ResultController : Controller
    {
        [HttpPost("result")]
        public IActionResult Result(string name, string location, string language, string comment )
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View();
        }
    }
}