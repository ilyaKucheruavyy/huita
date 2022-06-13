using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class SortedByComponents
    {
        private readonly WebDriver _driver;

        public SortedByComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SortBy(string sortedBy)
        {
            return _driver.FindElement(By.XPath($".//div[@role = 'menu']//a[contains(text(),'{sortedBy}')]"));
        }
    }
}
