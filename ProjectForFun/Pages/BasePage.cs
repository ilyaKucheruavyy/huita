using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProjectEtsy.Pages
{
    public abstract class BasePage
    {
        public WebDriver Driver { get; set; }

        public Actions Actions { get; set; }
    }
}