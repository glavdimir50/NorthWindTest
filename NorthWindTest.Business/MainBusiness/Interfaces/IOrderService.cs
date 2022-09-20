using NorthWindTest.Entity.Data.Api;
using NorthWindTest.Entity.VM.DataTable;
using NorthWindTest.Entity.VM.Home;
using NorthWindTest.Entity.VM.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindTest.Business.MainBusiness.Interfaces
{
    public interface IOrderService
    {
        Task<Result<DataTableRespVM<GetOrderRespVM>>> GetOrderListAsync(DataTableReqVM dtvm, GetOrderReqVM vm);
    }
}
