using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.Business.MainBusiness.Interfaces;
using NorthWindTest.Entity.VM.DataTable;
using NorthWindTest.Entity.VM.Home;
using System;
using System.Threading.Tasks;

namespace NorthWindTest.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IServiceProvider provider)
        {
            _orderService = provider.GetRequiredService<IOrderService>();
        }

        public IActionResult OrderQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetOrderList(DataTableReqVM dtvm, GetOrderReqVM vm)
        {
            var result = await _orderService.GetOrderListAsync(dtvm, vm);
            return Json(result.Model);
        }
    }
}
