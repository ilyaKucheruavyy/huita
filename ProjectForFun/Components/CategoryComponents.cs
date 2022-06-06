using OpenQA.Selenium;


namespace huita.Components
{
    public class CategoryComponents
    {
        private readonly WebDriver _driver;

        public CategoryComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ChooseCategory(string categoryName)
        {
            return _driver.FindElement(By.XPath($".//p[contains(text(),'{categoryName}')]"));
        }
    }
}
