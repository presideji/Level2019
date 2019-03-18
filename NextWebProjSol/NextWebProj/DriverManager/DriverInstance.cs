using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace NextWebProj.DriverManager
{
    public class DriverInstance
    {
        //public RemoteWebDriver Driver { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
