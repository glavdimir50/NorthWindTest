using NorthWindTest.Helper.DateTimeConverter;
using NUnit.Framework;
using System;

namespace NorthWindTest.NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DateConvertTest()
        {
            DateTime dateTime = DateTime.Now;
            string expected = "2022/09/21";
            string result = DateTimeConvert.ToDateTimeStr(dateTime);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}