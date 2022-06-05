using TechTalk.SpecFlow;
using OpenQA.Selenium;
using huita.Helper;
using huita.Etsy;
using System.Threading;
using huita.Components;

namespace huita
{
    [Binding]
    public class EtsySteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsySteps(WebDriver driver)
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

        [When(@"User click to first product")]
        public void WhenUserClickToFirstProduct()
        {
            _driver.WaitForElementToBeDisplayed(locators.SelectFirstProduct);
            (locators.SelectFirstProduct).Click();
            _driver.SwitchToNewWindow();
            _driver.ScrollPage(0, 50);
        }

        [When(@"User select product")]
        public void WhenUserSelectProduct()
        {
            _driver.SelectSomeElementByValue(locators.ChooseProductSize, locators.ProductSizeValue);
            _driver.WaitForElementToBeDisplayed(locators.ChooseProductOption);
            _driver.SelectSomeElementByValue(locators.ChooseProductOption, locators.ProductOptionValue);

            _driver.WaitForElementToBeDisplayed(locators.AddToCartButton);
            (locators.AddToCartButton).Click();
        }

        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            throw new PendingStepException();
        }
    }
}
