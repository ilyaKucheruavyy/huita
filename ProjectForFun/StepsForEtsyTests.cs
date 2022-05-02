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
            _driver.WaitElement(10);
            Utilits.MoveToElement(_driver, locators.MoveToCategory);
            (locators.ClickToFilmsMenu).Click();
        }

        [When(@"User searach some product")]
        public void WhenUserSearchSomeProduct()
        {
            _driver.WaitElement(locators.SearchingField, 10);
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
            _driver.WaitElement(locators.ClickToFilters, 10);
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
            _driver.WaitElement(locators.SelectFirstProduct, 10);
            (locators.SelectFirstProduct).Click();
            Utilits.SwitchToNewWindow(_driver);
            _driver.ScrollPage(0, 50);
        }

        [When(@"User select product")]
        public void WhenUserSelectProduct()
        {
            Utilits.SelectSomeElementByValue(_driver, locators.ChooseProductSize, locators.ProductSizeValue);
            _driver.WaitElement(locators.ChooseProductOption, 10);
            Utilits.SelectSomeElementByValue(_driver, locators.ChooseProductOption, locators.ProductOptionValue);

            _driver.WaitElement(locators.AddToCartButton, 10);
            (locators.AddToCartButton).Click();
        }

        [When(@"User wait for element to be displayed")]
        public void WhenUserWaitForElementToBeDisplayed()
        {
            var testElement = _driver.FindElement(By.XPath(""));
            _driver.WaitForElementToBeDisplayed(testElement); // вот тебе и перегрузка, € написал два метода с одинаковыми названи€ми, но разной перегрузкой, этот принимает веб≈лемент
            _driver.WaitForElementToBeDisplayed(By.XPath("нужный тебе хпас, или вытащил с пейджи переменную этого хпаса")); // а этот бай локатор, так шо можно не ебать мозги и в зависимости от ситуации пользовать "один и тот же" метод, хех)
        }

        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            throw new PendingStepException();
        }
    }
}
