using TestProjectEtsy.Base;
using OpenQA.Selenium;



namespace TestProjectEtsy.Components
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
