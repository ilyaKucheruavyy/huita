using System;
using TechTalk.SpecFlow;
using huita.Base;
using OpenQA.Selenium;
using huita.Helper;
using huita.Etsy;
using System.Threading;

namespace huita
{
    [Binding]
    public class StepsForEtsyTests : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public StepsForEtsyTests(WebDriver driver)
        {
            _driver = driver;
        }

        LocatorsForEtsyTests locators = new();

        

        [Given(@"User go to Etsy")]
        public void GivenUserGoToEtsy()
        {
            var baseUrl = "https://www.etsy.com/";

            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();
        }

        [When(@"User go to fims menu")]
        public void WhenUserGoToFimsMenu()
        {
            Utilits.MoveToElement(_driver, locators.MoveToCategory);
            (locators.ClickToFilmsMenu).Click();
        }

        [When(@"User searach some product")]
        public void WhenUserSearchSomeProduct()
        {
            _driver.WaitForElementToBeDisplayed(locators.SearchingField);
            Utilits.MoveToElementAndClick(_driver, locators.SearchingField);
            _driver.InputSomeText(locators.SearchingField, ProductsName.Rocky);
        }

        [When(@"User sorted selected product")]
        public void WhenUserSortedSomeProduct()
        {
            (locators.SortedByButton).Click();
            Utilits.SortedBySomeWorld(_driver, locators.SortedBy, NameSorted.ByHighiestPrice);
            Thread.Sleep(1000);
        }

        [When(@"User choose some filters")]
        public void WhenUserChooseSomeFilters()
        {
            _driver.WaitForElementToBeDisplayed(locators.ClickToFilters);
            (locators.ClickToFilters).Click();

            Utilits.WhenUserSelectCheckbox(_driver, locators.ClickToFreeShipping);
            Utilits.WhenUserSelectCheckbox(_driver, locators.ClickToShippingSale);

            Thread.Sleep(1000);
            Utilits.ScrollToElementWithJS(_driver, locators.TypeOfProduct);
            Utilits.WhenUserSelectCheckbox(_driver, locators.TypeOfProduct);
            Utilits.WhenUserSelectCheckbox(_driver, locators.SubmitButton);
        }

        [When(@"User click to first product")]
        public void WhenUserClickToFirstProduct()
        {
            _driver.WaitForElementToBeDisplayed(locators.SelectFirstProduct);
            (locators.SelectFirstProduct).Click();
            Utilits.SwitchToNewWindow(_driver);
            _driver.ScrollPage(0, 50);
        }

        [When(@"User select product")]
        public void WhenUserSelectProduct()
        {
            Utilits.SelectSomeElementByValue(_driver, locators.ChooseProductSize, locators.ProductSizeValue);
            _driver.WaitForElementToBeDisplayed(locators.ChooseProductOption);
            Utilits.SelectSomeElementByValue(_driver, locators.ChooseProductOption, locators.ProductOptionValue);

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
