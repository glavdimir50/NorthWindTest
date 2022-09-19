using NorthWindTest.Entity.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthWindTest.DataAccess.Interfaces
{
    public interface ICustomerDbService
    {

        /// <summary>
        /// 搜尋全部客戶
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customers> GetCustomers();

        /// <summary>
        /// 搜尋全部客戶-字典
        /// </summary>
        /// <returns></returns>
        Task<Dictionary<string, string>> GetCustomersDictionaryAsync();
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
