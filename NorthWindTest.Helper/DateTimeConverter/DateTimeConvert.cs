using System;

namespace NorthWindTest.Helper.DateTimeConverter
{
    public static class DateTimeConvert
    {
        public static string ToDateTimeStr(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy/MM/dd");
        }
    }
}
