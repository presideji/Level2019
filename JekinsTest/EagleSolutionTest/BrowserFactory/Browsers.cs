using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EagleSolutionMyWay.DriverManager;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace EagleSolutionTest.BrowserFactory
{
    public abstract class Browsers : DriverInstance
    {
        internal abstract RemoteWebDriver LaunchBrowser();
        public RemoteWebDriver LaunchBrowser(string browserName)
        {
            switch (browserName)
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--disable-infobars");
                    Driver = new ChromeDriver(chromeOptions);
                    break;

                case "ie":
                    var options = new InternetExplorerOptions();
                    options.EnsureCleanSession = true;
                    Driver = new InternetExplorerDriver(options);
                    break;

                case "firefox":
                    Driver = new FirefoxDriver();
                    break;

                default:
                    Driver = new ChromeDriver();
                    break;
            }
            // Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
            return Driver;

        }


        public void CloseBrowser()
        {
            try
            {
                Driver?.Close();
                Driver?.Quit();
                Driver?.Dispose();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                throw;
            }
        }



    }
}
