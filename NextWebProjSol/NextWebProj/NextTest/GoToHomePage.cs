using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextWebProj.Hook;
using NextWebProj.Page;

namespace NextWebProj.NextTest
{
    [TestClass]

    public class GoToHomePage : TestHooks
    {
        [TestMethod]

        public void ValidatePage()
       {
            WelcomePage welcomePage = new WelcomePage(Driver);
            
            //title = Next Official Site: Online Fashion
            //var title = "Next Official Site: Online Fashion";
              welcomePage.GoToNextHomePage();  
        }
    }

}
