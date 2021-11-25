using Microsoft.AspNetCore.Mvc;

namespace Vidal.UI.AppModelo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
