using OpenQA.Selenium;
using TestProjectHotline.Helper;

namespace TestProjectHotline.Base
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