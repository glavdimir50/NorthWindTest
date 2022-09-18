using NorthWindTest.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Business.MainBusiness.Interfaces
{
    public interface ICustomerService
    {

        /// <summary>
        /// 搜尋全部客戶
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customers> GetCustomers();

        /// <summary>
        /// 根據客戶ID搜尋
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IEnumerable<Customers> GetCustomersById(string Id);

        /// <summary>
        /// 根據客戶City搜尋
        /// </summary>
        /// <param name="City"></param>
        /// <returns></returns>
        IEnumerable<Customers> GetCustomersByCity(string City);
    }
}
