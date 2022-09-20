using NorthWindTest.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindTest.DataAccess.Interfaces
{
    public interface IOrderDbService
    {
        /// <summary>
        /// 根據客戶ID查詢訂單列表
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<List<Orders>> GetOrderListByCustomerID(string Id);
    }
}
