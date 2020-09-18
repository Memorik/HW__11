using ConsoleApp31;
using NUnit.Framework;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test(Description = "Check calculator operators ")]
        public void TestPlus()
        {
            double result = new SimpleCalculator().Plus(10,2);
            Assert.AreEqual(12, result);

        }              

    }
}
