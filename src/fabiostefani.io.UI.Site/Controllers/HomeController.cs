using Microsoft.AspNetCore.Mvc;

namespace fabiostefani.io.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}