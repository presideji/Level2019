using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkPCUnitTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext testContext)
        {
            Console.WriteLine("Beofre Assembly");
           
        }


        [ClassInitialize]
        public static void BeforeClass(TestContext testContext)
        {
            Console.WriteLine("Class Initialize");
        }


        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is test initialize-run before test");
            Console.WriteLine("Launch browser");
        }

        
        [TestMethod]
        [TestCategory("Smoke Test")]
        public void TestMethod1()
        {
            Console.WriteLine("test1");
        }


        [TestMethod]
        [TestCategory("Regression Test")]
        public void TestMethod2()
        {
            Console.WriteLine("Test2");
        }

        [TestMethod]
        [TestCategory("UAT")]
        public void TestMethod3()
        {
            Console.WriteLine("This is the third Test");

        }


        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("test Clean up - run after test");
            Console.WriteLine("Close browser");
        }


        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("Class Cleanup");
        }


        [AssemblyCleanup]
        public static void AferAssenbly()
        {
            Console.WriteLine("After Assembly");
        }
    }
}
