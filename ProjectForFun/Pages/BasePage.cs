using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public abstract class BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//body")]
        public IWebElement BodyContainer { get; set; }

        public WebDriver Driver { get; set; }

        public Actions Actions { get; set; }

        public IWebStorage Storage;


    }
}
