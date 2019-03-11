using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JekinsTest.TestFolder
{
    [TestClass]
    public class FirtsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.next.co.uk/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sli_search_1")).SendKeys("Hello Lady");
            Thread.Sleep(10000);
            var result = driver.Title.Contains("Next");
            Assert.IsTrue(result);
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
        }


        [TestMethod]
        public void TestMethod5()
        {
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
        }
    }

}
