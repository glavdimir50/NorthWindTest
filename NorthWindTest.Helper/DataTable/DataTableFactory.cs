using Newtonsoft.Json;
using NorthWindTest.Entity.VM.DataTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthWindTest.Helper.DataTable
{
    public static class DataTableFactory
    {
        public static DataTableRespVM<T> GetDataTableRespData<T>(DataTableReqVM req, IEnumerable<T> queryResult)
        {
            IEnumerable<T> dataList = GetDataTableList(queryResult, req);

            DataTableRespVM<T> resp = new DataTableRespVM<T>();
            resp.Draw = req.Draw;
            resp.Data = JsonConvert.SerializeObject(GetPagingData(dataList, req.Start, req.Length));
            resp.RecordsTotal = queryResult.Count();
            resp.RecordsFiltered = string.IsNullOrEmpty(req.Search) ? queryResult.Count() : dataList.Count();

            return resp;
        }
        public static IEnumerable<T> GetDataTableList<T>(IEnumerable<T> dataList, DataTableReqVM req)
        {

            if (!string.IsNullOrEmpty(req.Search))
            {
                dataList = dataList.Where(d => d.GetType().GetProperties().Any(x => CheckData(req.Search.ToLower(), d, x)));
            }
            IEnumerable<T> sortData = GetSortData(dataList, req.Columns, req.Order);
            return sortData;
        }

        private static List<T> GetPagingData<T>(IEnumerable<T> dataList, int start, int length)
        {
            return dataList.Skip(start).Take(length).ToList();
        }
        private static IEnumerable<T> GetSearchData<T>(IEnumerable<T> dataList, string searchVal)
        {
            if (!string.IsNullOrEmpty(searchVal))
            {
                dataList = dataList.Where(x => x.GetType().GetProperties().Any()).ToList();
            }
            return dataList;
        }

        private static IEnumerable<T> GetSortData<T>(IEnumerable<T> dataList, List<Columns> columns, List<Order> orders)
        {
            if (orders != null && orders.Any())
            {
                foreach (var item in orders)
                {
                    var col = columns[item.Column];

                    if (col.Orderable)
                    {
                        var propertyInfo = typeof(T).GetProperty(col.Name);

                        if (item.Dir == "asc")
                        {
                            dataList = dataList.OrderBy(x => propertyInfo.GetValue(x, null)).ToList();
                        }
                        else if (item.Dir == "desc")
                        {
                            dataList = dataList.OrderByDescending(x => propertyInfo.GetValue(x, null)).ToList();
                        }
                    }
                }
            }

            return dataList;
        }

        private static bool CheckData<Data>(string searchVal, Data d, System.Reflection.PropertyInfo x)
        {
            bool result = CheckPropValueIsNotNull(d, x) && CheckValContainsVal(searchVal, d, x);
            return result;
        }

        private static bool CheckValContainsVal<T>(string searchVal, T m, System.Reflection.PropertyInfo x)
        {
            var val = x.GetValue(m, null).ToString().ToLower();
            bool result = val.Contains(searchVal);
            return result;
        }

        private static bool CheckPropValueIsNotNull<T>(T data, System.Reflection.PropertyInfo x)
        {
            var val = x.GetValue(data, null);
            bool result = val != null;
            return result;
        }
    }
}
