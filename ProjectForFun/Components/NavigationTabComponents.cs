using huita.Base;
using OpenQA.Selenium;



namespace huita.Components
{
    public class NavigationTabComponents
    {

        private readonly WebDriver _driver;

        public NavigationTabComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement NavigationTabs(string identifier)
        {
            return _driver.FindElement(By.XPath($".//span[contains(text(),'{identifier}')]"));
        }

        public IWebElement NavigationSubMenu(string identifier)
        {
            return _driver.FindElement(By.XPath($".//a[contains(text(),'{identifier}')]"));
        }
    }
}
