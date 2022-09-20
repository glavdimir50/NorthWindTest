using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Entity.VM.DataTable
{
    public class DataTableReqVM
    {
        public int Draw { get; set; }

        public int Start { get; set; }

        public int Length { get; set; }

        public List<Columns> Columns { get; set; }

        public List<Order> Order { get; set; }

        public string Search { get; set; }
    }
}
