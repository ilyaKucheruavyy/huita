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

        public void ClickCheckbox(string filterName)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript($"var a = document.evaluate('.//div[@class = 'main-filters']//label[contains(text(),'{filterName}')]', document).iterateNext(); a.click();");
        }
    }
}
