using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using JekinsTest.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace JekinsTest.BrowserFactory
{
    public class Browsers
    {

        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private IWebDriver driver;
        public IWebDriver LoadBrowser()
        {
            //var baseUrl = Config.Test.Default.BaseUrl;
            //var browser = Test.Default.Browser.ToLower();

            //if (browser.Contains("chrome"))
            //{
            //    driver = new ChromeDriver();
            //}

            var browser = Config.Test.Default.Browser.ToLower();
            if (browser.Contains("chrome")) driver = new ChromeDriver();
           ///// if (browser.Contains("firefox")) driver = new FirefoxDriver();
            Logger.Info("Successfully open " + browser + "browser");
            driver.Manage().Window.Maximize();
            Logger.Info("Successfully maximize browser");
            driver.Navigate().GoToUrl(Config.Test.Default.BaseUrl);
            Logger.Info("Successfully navigated to the " + Config.Test.Default.BaseUrl);
            return driver;
        }

        public void UnloadBrowser()
        {
            driver.Quit();
        }
    }
}
