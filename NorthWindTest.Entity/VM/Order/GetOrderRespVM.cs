using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Entity.VM.Order
{
    public class GetOrderRespVM
    {
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
    }
}
