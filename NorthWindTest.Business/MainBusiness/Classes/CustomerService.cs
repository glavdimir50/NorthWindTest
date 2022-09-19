using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.Business.MainBusiness.Interfaces;
using NorthWindTest.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Business.MainBusiness.Classes
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDbService _customerDbService;
        public CustomerService(IServiceProvider provider)
        {
            _customerDbService = provider.GetRequiredService<ICustomerDbService>();
        }


    }
}
