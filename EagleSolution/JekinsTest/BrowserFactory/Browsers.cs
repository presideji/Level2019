using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using JekinsTest.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace JekinsTest.BrowserFactory
{
    public class Browsers
    {

        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public IWebDriver Driver;

        public static IWebDriver WebDriver { get; set; }

        public IWebDriver LoadBrowser()
        {
            //var baseUrl = Config.Test.Default.BaseUrl;
            //var browser = Test.Default.Browser.ToLower();

            //if (browser.Contains("chrome"))
            //{
            //    driver = new ChromeDriver();
            //}

            var browser = Config.Test.Default.Browser.ToLower();
            if (browser.Contains("chrome")) Driver = new ChromeDriver();
            ///// if (browser.Contains("firefox")) driver = new FirefoxDriver();
            //if (browser.Contains("phantomjs")) Driver = new PhantomJSDriver();
            Logger.Info("Successfully open " + browser + "browser");
            Driver.Manage().Window.Maximize();
            Logger.Info("Successfully maximize browser");
            Driver.Navigate().GoToUrl(Config.Test.Default.BaseUrl);
            Logger.Info("Successfully navigated to the " + Config.Test.Default.BaseUrl);
            return Driver;
        }

        
        public void UnloadBrowser()
        {
            Driver.Quit();
        }
    }
}
