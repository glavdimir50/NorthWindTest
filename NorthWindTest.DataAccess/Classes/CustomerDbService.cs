using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace NorthWindTest.DataAccess.Classes
{
    public class CustomerDbService : ICustomerDbService
    {
        //private IGenericRepository<Customers> _customersRepo;
        private DbSet<Customers> _context;

        public CustomerDbService(IServiceProvider provider)
        {
            _context = provider.GetRequiredService<NorthwindContext>().Customers;
        }

        /// <summary>
        /// 搜尋全部客戶
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customers> GetCustomers()
        {
            return _context;
        }

        /// <summary>
        /// 搜尋全部客戶-字典
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<string,string>> GetCustomersDictionaryAsync()
        {
            return await _context.ToDictionaryAsync(x=>x.CustomerId, x=>x.CompanyName);
        }

        /// <summary>
        /// 根據客戶ID搜尋
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IEnumerable<Customers> GetCustomersById(string Id)
        {
            return _context.Where(x=>x.CustomerId == Id);
        }

        /// <summary>
        /// 根據客戶City搜尋
        /// </summary>
        /// <param name="City"></param>
        /// <returns></returns>
        public IEnumerable<Customers> GetCustomersByCity(string City)
        {
            return _context.Where(x=>x.City == City);
        }
    }
}
