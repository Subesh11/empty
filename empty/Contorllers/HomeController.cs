using Microsoft.AspNetCore.Mvc;

namespace empty.Contorllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ABout()
        {
            var a=ViewData["Data"];
            ViewData["data"] = a;
            return View();
        }
    }
}
