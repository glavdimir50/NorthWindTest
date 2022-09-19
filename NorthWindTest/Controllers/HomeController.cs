using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.Business.MainBusiness.Interfaces;
using System;
using System.Threading.Tasks;

namespace NorthWindTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;
        public HomeController(IServiceProvider provider)
        {
            _customerService = provider.GetRequiredService<ICustomerService>();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCustomers()
        {
            var result = await _customerService.GetCustomersList();
            return Json(result);
        }
    }
}
