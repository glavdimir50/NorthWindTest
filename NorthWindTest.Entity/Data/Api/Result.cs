using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Entity.Data.Api
{
    public class Result<T>
    {
        /// <summary>
        /// 狀態   
        /// </summary>
        public bool OK { get; set; }

        /// <summary>
        /// 代碼
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// 訊息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 資料物件
        /// </summary>
        public T Model { get; set; }
    }
}
