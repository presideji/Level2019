using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextWebProj.Browser;
using NextWebProj.Config;
using NextWebProj.DriverManager;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace NextWebProj.Hook
{

    public class TestHooks : DriverInstance
       
    {
        

        // Choosing Browser type
        public string BrowserName = Configs.Default.ChromeBrowser;

        
        
        Browsers browsers = new Browsers();
        public Browsers browser;
       // public RemoteWebDriver driver;

        public IWebDriver driver;
        private static string browserName;

        public TestContext testContext { get; set; }

        [AssemblyInitialize]
        public static void InitWebDriver()
        {
            
            Browsers.LaunchBrowser(browserName);

        }



        [AssemblyCleanup]
        public static void TearDown(Browsers browser)
        {
            browser.CloseBrowser();
        }



        //[TestInitialize]
        //public static void TestInitialize(Browsers browser)
        //{
        //    //.browser = new Browsers();

        //    Driver = browser.LaunchBrowser(browserName);
        //}


        //[TestCleanup]
        //public void TestCleanup()
        //{
        //   // browser.CloseBrowser();
        //}



    }

}

