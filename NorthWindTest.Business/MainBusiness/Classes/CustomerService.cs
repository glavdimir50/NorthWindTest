using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using NorthWindTest.Business.MainBusiness.Interfaces;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Data.Api;
using NorthWindTest.Entity.VM.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NorthWindTest.Business.MainBusiness.Classes
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDbService _customerDbService;
        public CustomerService(IServiceProvider provider)
        {
            _customerDbService = provider.GetRequiredService<ICustomerDbService>();
        }

        public async Task<Result<CustomersListRespVM>> GetCustomersList()
        {
            var customersDictionary = await _customerDbService.GetCustomersDictionaryAsync();
            CustomersListRespVM vm = new CustomersListRespVM();
            vm.CustomersList = JsonConvert.SerializeObject(customersDictionary);
            return await ResultMethod.SuccessAsync(vm);
        }
    }
}
