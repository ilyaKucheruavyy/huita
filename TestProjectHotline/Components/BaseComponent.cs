using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectHotline.Components
{
    public class BaseComponent
    {
        public WebDriver Driver { get; set; }

        public void InitElement()
        {
            PageFactory.InitElements(Driver, this);
        }
    }
}
