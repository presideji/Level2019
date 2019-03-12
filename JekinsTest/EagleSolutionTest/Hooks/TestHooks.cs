using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EagleSolutionMyWay.DriverManager;
using EagleSolutionTest.BrowserFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace EagleSolutionTest.Hooks
{
    public class TestHooks : DriverInstance
    {
        private Browsers browser;
        //protected IWebDriver Driver;
        public TestContext testContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {


        }



        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }



        [TestInitialize]
        public void TestInitialize()
        {
            //this.browser = new Browsers();
            Driver = browser.LaunchBrowser();

        }



        [TestCleanup]
        public void TestCleanup()
        {
            browser.CloseBrowser();
        }









    }
}
