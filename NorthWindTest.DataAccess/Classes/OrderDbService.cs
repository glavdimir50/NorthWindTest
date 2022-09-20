using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWindTest.DataAccess.Classes
{
    public class OrderDbService : IOrderDbService
    {
        private DbSet<Orders> _context;

        public OrderDbService(IServiceProvider provider)
        {
            _context = provider.GetRequiredService<NorthwindContext>().Orders;
        }

        /// <summary>
        /// 根據客戶ID查詢訂單列表
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<List<Orders>> GetOrderListByCustomerID(string Id)
        {
            return await _context.Where(x => x.CustomerId == Id).ToListAsync();
        }
    }
}
