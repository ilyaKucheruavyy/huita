using OpenQA.Selenium;

namespace TestProjectEtsy.Base
{
    public interface IBaseTest
    {
        WebDriver Driver { get; set; }

        WebDriver CreateBrowserDriver();
    }
}
