using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using JekinsTest.BrowserFactory;
using JekinsTest.Utilities;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace JekinsTest.Test.Hooks
{
    [TestClass]
    public class TestHooks
    {
        private Browsers browser;
        protected IWebDriver Driver;
        public TestContext TestContext { get; set; }


        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            XmlConfigurator.Configure();
        }



        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }



        [TestInitialize]
        public void TestInitialize()
        {
            browser = new Browsers();
            Driver = browser.LoadBrowser();
        }



        [TestCleanup]
        public void TestCleanup()
        {
            var shot = new ScreenShot();
            shot.TakeShot(TestContext);

            browser.UnloadBrowser();
        }

        [ClassInitialize]
        public static void ClassInitialize()
        {
            
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }


    }
}
