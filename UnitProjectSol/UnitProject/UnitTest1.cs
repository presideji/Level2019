using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace UnitProject
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod, TestCategory("Smoke Test")]
        public void LaunchBrowserAndCloseBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://kress2m1.github.io/prog-mine.html");
            driver.FindElement(By.LinkText("Automation Course")).Click();
            driver.Close();
            driver.Quit();
            //driver.Dispose();
            
        }

        [TestMethod, TestCategory("Smoke Test")]
        public void Navigate()
        {

        }

    }
}
