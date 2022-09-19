using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Entity;
using System;
using System.Collections.Generic;

namespace NorthWindTest.DataAccess.Classes
{
    public class CustomerDbService : ICustomerDbService
    {
        private IGenericRepository<Customers> _customersRepo;

        public CustomerDbService(IServiceProvider provider)
        {
            _customersRepo = provider.GetRequiredService<IGenericRepository<Customers>>();
        }

        /// <summary>
        /// 搜尋全部客戶
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customers> GetCustomers()
        {
            return _customersRepo.Filter();
        }

        /// <summary>
        /// 根據客戶ID搜尋
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IEnumerable<Customers> GetCustomersById(string Id)
        {
            return _customersRepo.Filter(x=>x.CustomerId == Id);
        }

        /// <summary>
        /// 根據客戶City搜尋
        /// </summary>
        /// <param name="City"></param>
        /// <returns></returns>
        public IEnumerable<Customers> GetCustomersByCity(string City)
        {
            return _customersRepo.Filter(x=>x.City == City);
        }
    }
}
