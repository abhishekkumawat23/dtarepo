using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            Console.WriteLine("Add test start");

            // Intializations
            int x = 4;
            int y = 5;
            int expectedResult = 9;

            // Method call
            int actualResult = Program.Add(x, y);

            // Verifications
            Assert.AreEqual(actualResult, expectedResult);

            Console.WriteLine("Add test end");
        }

        [TestMethod]
        public void SubtractTest()
        {
            Console.WriteLine("Subtract test start");
            // Intializations
            int x = 7;
            int y = 2;
            int expectedResult = 5;

            // Method call
            int actualResult = Program.Subtract(x, y);

            // Verifications
            Assert.AreEqual(actualResult, expectedResult);
            //Assert.Fail("Subtract test failed");

            Console.WriteLine("Subtract test end");
        }
    }
}
