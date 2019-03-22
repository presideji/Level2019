using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;

namespace JekinsTest.Pages
{
    public class WelcomePage : BasePage
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public WelcomePage(IWebDriver driver) : base(driver)
        {

        }

        public bool ValidatePageTitle(string title)
        {
            Logger.Info("The page title is "+ Driver.Title);
            return Driver.Title.ToLower().Contains(title.ToLower());
        }

        public bool ValidateItem(string item)
        {
            return Driver.PageSource.ToLower().Contains(item.ToLower());
        }
    }
}
