using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Priority(1)]
        public void TestMethod1()
        {
            Console.WriteLine("hellO");
            Console.WriteLine(TestContext.Properties["testMyValue"]);
            //Assert.AreEqual(TestContext.Properties["testMyValue"], "right");
            Console.WriteLine("hello world");
        }

        [TestMethod]
        public void BitnessCheck()
        {
            //Assert.Fail("I am bound to fail");
        }

        [TestMethod]
        public void KillCurrentProcess()
        {
            //Assert.Inconclusive("hello inconclusive");
            //not yet            
            //Assert.Fail("I am bound to fail");
        }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
