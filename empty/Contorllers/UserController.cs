using Microsoft.AspNetCore.Mvc;

namespace empty.Contorllers
{
    public class UserController : Controller
    {
        public IActionResult Action()
        {
            TempData["Data"] = "Programmer";
            return View();
        }
        public IActionResult IndZex()
        {
            return View();
        }
    }
}
