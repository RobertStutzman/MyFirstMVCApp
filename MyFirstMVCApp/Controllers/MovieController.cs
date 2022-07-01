using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
