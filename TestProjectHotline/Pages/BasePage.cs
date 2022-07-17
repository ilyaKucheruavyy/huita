using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace TestProjectHotline.Pages
{
    public abstract class BasePage
    {
        public WebDriver Driver { get; set; }

        public Actions Actions { get; set; }

        public void InitElement()
        {
            PageFactory.InitElements(Driver, this);
        }
    }
}