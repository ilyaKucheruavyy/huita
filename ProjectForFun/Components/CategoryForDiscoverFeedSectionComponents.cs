

using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class CategoryForDiscoverFeedSectionComponents
    {
        private readonly IWebDriver _driver;

        public CategoryForDiscoverFeedSectionComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement CategoryForDiscoverFeedSection(string categoryName)
        {
            return _driver.FindElement(By.XPath($".//button[@id = '{categoryName}-tab']"));
        }
    }
}
