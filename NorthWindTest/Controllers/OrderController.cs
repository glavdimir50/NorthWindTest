using Microsoft.AspNetCore.Mvc;

namespace NorthWindTest.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult OrderQuery()
        {
            return View();
        }
    }
}
