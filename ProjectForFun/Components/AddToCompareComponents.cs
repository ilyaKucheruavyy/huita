
using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class AddToCompareComponents
    {
        private readonly WebDriver _driver;

        public AddToCompareComponents (WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UserClickOnCheckboxAddedToCompare(string productName)
        {
            return _driver.FindElement
                (By.XPath
                ($".//div[@class = 'list-body']//div[@class = 'list-item__title-container m_b-5']//a[contains(text(),'{productName}')]//parent::div//parent::div//preceding-sibling::div//input"));
        }
    }
}
