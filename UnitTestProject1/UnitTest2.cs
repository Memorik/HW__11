using System;
using ConsoleApp31;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest2
    {
        [SetUp]
        public void Calc_Open()
        {
            Console.WriteLine("Open console");
        }

        [TearDown]
        public void Calc_Result()
        {
            Console.WriteLine("Take screenshot and save it");
        }

        [OneTimeTearDown]
        public void Calc_Endt()
        {
            Console.WriteLine("Close the console");
        }

        [TestCase(10,2,5)]
        [TestCase(11, 2, 13)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(10, 2, 12)]

        public void TestMethod1(int a, int b, double expectedResult)
        {
            double result = new SimpleCalculator().Plus(a, b);
            Assert.AreEqual(expectedResult, result);
        }

       
    }
}
