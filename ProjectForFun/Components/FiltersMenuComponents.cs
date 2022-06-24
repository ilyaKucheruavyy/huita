using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class FiltersMenuComponents
    {
        private readonly WebDriver _driver;

        public FiltersMenuComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UserClickOnCheckBox(string filterName)
        {
            return _driver.FindElement(By.XPath($".//div[@class = 'sidebar-filter__body']//div[contains(text(),'{filterName}')]//preceding-sibling::input"));
        }
    }
}
