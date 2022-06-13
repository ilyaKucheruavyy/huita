using TestProjectEtsy.Helper;
using OpenQA.Selenium;

namespace TestProjectEtsy.Base
{
    public class BaseTest : IBaseTest
    {
        public WebDriver Driver { get; set; }

        public WebDriver CreateBrowserDriver()
        {
            return BrowserFactory.CreateLocalDriver();
        }
    }
}