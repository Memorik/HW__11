using System;
using ConsoleApp31;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest3
    {
        [TestCase(10, 2, 5)]
        [TestCase(11, 2, 5.5)]
        [TestCase(1, 0, 1)]
  

        public void TestMethod2(int a, int b, double expectedResult)
        {
            double result = new SimpleCalculator().Division(a, b);
            Assert.AreEqual(expectedResult, result);
        }


    }
}
