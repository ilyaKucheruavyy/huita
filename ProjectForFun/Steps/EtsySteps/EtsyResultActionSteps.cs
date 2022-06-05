using TechTalk.SpecFlow;
using OpenQA.Selenium;
using huita.Helper;
using huita.Etsy;
using System.Threading;

namespace huita.Steps.EtsySteps
{
    [Binding]
    public class EtsyResultActionSteps: SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsyResultActionSteps(WebDriver driver)
        {
            _driver = driver;
        }

        EtsyLocators locators = new();

        [When(@"User sorted product by '(.*)'")]
        public void WhenUserSortedSomeProduct(string sortedBy)
        {
            (locators.SortedByButton).Click();
            _driver.SortedBySomeWorld(locators.SortedBy, sortedBy);
            Thread.Sleep(1000);
        }

        [When(@"User choose some filters")]
        public void WhenUserChooseSomeFilters()
        {
            _driver.WaitForElementToBeDisplayed(locators.ClickToFilters);
            (locators.ClickToFilters).Click();

            _driver.WhenUserSelectCheckbox(locators.ClickToFreeShipping);
            _driver.WhenUserSelectCheckbox(locators.ClickToShippingSale);

            Thread.Sleep(1000);
            _driver.ScrollToElementWithJS(locators.TypeOfProduct);
            _driver.WhenUserSelectCheckbox(locators.TypeOfProduct);
            _driver.WhenUserSelectCheckbox(locators.SubmitButton);
        }
    }
}
