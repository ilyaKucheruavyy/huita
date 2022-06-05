using TechTalk.SpecFlow;
using OpenQA.Selenium;
using huita.Helper;
using huita.Etsy;

namespace huita.Steps.EtsySteps
{
    [Binding]
    public class EtsySearchSteps: SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsySearchSteps(WebDriver driver)
        {
            _driver = driver;
        }

        EtsyLocators locators = new();

        [When(@"User searach product '(.*)'")]
        public void WhenUserSearchSomeProduct(string productName)
        {
            _driver.WaitForElementToBeDisplayed(locators.SearchingField);
            _driver.MoveToElementAndClick(locators.SearchingField);
            _driver.InputSomeText(locators.SearchingField, productName);
        }
    }
}
