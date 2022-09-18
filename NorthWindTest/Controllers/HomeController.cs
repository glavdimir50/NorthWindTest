using Microsoft.AspNetCore.Mvc;

namespace NorthWindTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
