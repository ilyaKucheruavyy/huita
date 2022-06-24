using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectEtsy.Pages
{
    public abstract class BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//body")]
        public IWebElement BodyContainer { get; set; }

        public WebDriver Driver { get; set; }

        public Actions Actions { get; set; }

        public IWebStorage Storage;

        public void InitElements()
        {
            PageFactory.InitElements(Driver, this);

            Storage = new WebStorage(Driver);
        }
    }
}
