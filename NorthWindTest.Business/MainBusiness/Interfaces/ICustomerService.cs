using NorthWindTest.Entity.Data.Api;
using NorthWindTest.Entity.VM.Home;
using System.Threading.Tasks;

namespace NorthWindTest.Business.MainBusiness.Interfaces
{
    public interface ICustomerService
    {
        Task<Result<CustomersListRespVM>> GetCustomersListAsync();
    }
}
