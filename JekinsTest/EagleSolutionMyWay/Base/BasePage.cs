using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EagleSolutionMyWay.Config;
using EagleSolutionMyWay.DriverManager;
using OpenQA.Selenium.Remote;

namespace EagleSolutionMyWay.Base
{
    public class BasePage : DriverInstance
    {
        public BasePage(RemoteWebDriver driver)
        {
            Driver = driver;
        }
        public string ValtechHomepage = Config.Default.ValtechHomePage;
        public string BaseUrl = Config.Config.Default.BaseUrl;




    }
}
