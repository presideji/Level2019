using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using JekinsTest.BrowserFactory;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace JekinsTest.Utilities
{
    public class ScreenShot : Browsers
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void TakeShot(TestContext testContext)
        {

            if (testContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                GrabScreen(testContext);

            }
            else if (testContext.CurrentTestOutcome == UnitTestOutcome.Error)
            {
                GrabScreen(testContext);
            }
            else if ((testContext.CurrentTestOutcome == UnitTestOutcome.Aborted))
            {
                GrabScreen(testContext);
            }
            else if ((testContext.CurrentTestOutcome == UnitTestOutcome.Passed))
            {
                Logger.Info("The test passed successfully");
            }
            else if ((testContext.CurrentTestOutcome == UnitTestOutcome.Timeout))
            {
                Logger.Info("The test timed out");
            }
        }

        private void GrabScreen(TestContext testContext)
        {
            Logger.Error("The test failed and about to grab a screenshot");


            var filename = Path.Combine(Directory.GetCurrentDirectory() + "\\AutomatedTestReport\\Screenshots\\") + DateTime.Now.ToString("yy-MM-dd-HH-mm-ss-FFF") + "-" +
               this.GetType().Name + "-" + testContext.TestName + ".jpeg";


            ((ITakesScreenshot)Driver).GetScreenshot()
                .SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            testContext.AddResultFile(filename);
            Logger.Debug("The screen has been taken and stored as " +filename);
        }
    }
}
