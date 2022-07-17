using OpenQA.Selenium;

namespace TestProjectHotline.Base
{
    public interface IBaseTest
    {
        WebDriver Driver { get; set; }

        WebDriver CreateBrowserDriver();
    }
}
