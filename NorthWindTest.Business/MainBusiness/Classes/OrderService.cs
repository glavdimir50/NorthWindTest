using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.Business.MainBusiness.Interfaces;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Data.Api;
using NorthWindTest.Entity.VM.DataTable;
using NorthWindTest.Entity.VM.Home;
using NorthWindTest.Entity.VM.Order;
using NorthWindTest.Helper.DataTable;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWindTest.Business.MainBusiness.Classes
{
    public class OrderService : IOrderService
    {
        private readonly IOrderDbService _orderDbService;
        
        public OrderService(IServiceProvider provider)
        {
            _orderDbService = provider.GetRequiredService<IOrderDbService>();
        }

        public async Task<Result<DataTableRespVM<GetOrderRespVM>>> GetOrderListAsync(DataTableReqVM dtvm, GetOrderReqVM vm)
        {
            var orderList = await _orderDbService.GetOrderListByCustomerID(vm.Id);
            var orderRespVM = orderList.Select(order => new GetOrderRespVM()
            {
                OrderID = order.OrderId.ToString(),
                OrderDate = order.OrderDate.ToString(),
                RequiredDate = order.RequiredDate.ToString(),
                ShippedDate = order.ShippedDate.ToString()
            });

            var resp = DataTableFactory.GetDataTableRespData(dtvm, orderRespVM);
            return await ResultMethod.SuccessAsync(resp);
        }

    }
}
