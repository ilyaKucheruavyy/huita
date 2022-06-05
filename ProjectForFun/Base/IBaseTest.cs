using OpenQA.Selenium;

namespace huita.Base
{
    public interface IBaseTest
    {
        WebDriver Driver { get; set; }

        WebDriver CreateBrowserDriver();
    }
}
