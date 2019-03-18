using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextWebProj.Base;
using NextWebProj.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace NextWebProj.Page
{
    public class WelcomePage : BasePage
    {
        public WelcomePage(IWebDriver driver) : base(driver)
        {

        }

        public bool ValidatePageTitle(string title)
        {
            //Logger.Info("The page title is " + Driver.Title);
            return Driver.Title.ToLower().Contains(title.ToLower());
        }

        public void GoToNextHomePage()
        {
            NavigateToUrl(Configs.Default.BaseUrl);
        }
    }
}
