using huita.Helper;
using OpenQA.Selenium;

namespace huita.Base
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