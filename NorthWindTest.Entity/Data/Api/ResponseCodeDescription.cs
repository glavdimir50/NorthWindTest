using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Entity.Data.Api
{
    public static class ResponseCodeDescription
    {
        public static readonly IReadOnlyDictionary<string, string> GetMessage = new Dictionary<string, string>
        {
            { ResponseCode.Success, "成功"},
        };
    }
}
