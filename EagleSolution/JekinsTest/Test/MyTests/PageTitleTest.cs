using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JekinsTest.Pages;
using JekinsTest.Test.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JekinsTest.Test.MyTests
{
    [TestClass]
    public class PageTitleTest : TestHooks
    {
        [TestMethod]
        public void ValidatingPageTitle()
        {
            //title = Next Official Site: Online Fashion
            var title = "Next Official Site: Online Fashion";


            WelcomePage welcomePage = new WelcomePage(Driver);
            var result = welcomePage.ValidatePageTitle(title);
            Assert.IsTrue(result);

        }


        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
            Console.WriteLine("This is test to see if test runs on the Jenkins environment");
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
