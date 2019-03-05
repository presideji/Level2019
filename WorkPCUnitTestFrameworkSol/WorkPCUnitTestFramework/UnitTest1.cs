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
            Console.WriteLine("Before Assembly");
           
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
        [TestCategory("Smoke Test"), Ignore]
        public void CreateAccount()
        {
            Console.WriteLine("CREATE A USER ACCOUNT");
        }

        
        [TestMethod]
        [TestCategory("UAT test")]
        public void LogIntoAccount()
        {
            Console.WriteLine("LOG INTO THE APPLICATION");

        }


        [TestMethod]
        [TestCategory("Regression Test")]
        public void LogOutOfAccount()
        {
            Console.WriteLine("LOG OUT OF ACCOUNT");
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
        public static void AferAssembly()
        {
            Console.WriteLine("After Assembly");
        }

    }
}
