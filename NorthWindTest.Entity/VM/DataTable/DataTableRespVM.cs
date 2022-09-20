using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindTest.Entity.VM.DataTable
{
    public class DataTableRespVM<T>
    {
        public string Data { get; set; }

        public int Draw { get; set; }

        public int RecordsTotal { get; set; }

        public int RecordsFiltered { get; set; }
    }
}
