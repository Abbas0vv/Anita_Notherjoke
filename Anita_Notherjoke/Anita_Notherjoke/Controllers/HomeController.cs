using Microsoft.AspNetCore.Mvc;

namespace Anita_Notherjoke.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
