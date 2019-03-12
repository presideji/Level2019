using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace EagleSolutionMyWay.DriverManager
{
    public class DriverInstance
    {
        protected RemoteWebDriver Driver { get; set; }
    }
}
