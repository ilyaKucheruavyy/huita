using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using TechTalk.SpecFlow;
using TestProjectEtsy.Extensions;
using TestProjectEtsy.Pages;

namespace TestProjectEtsy.Steps.HotLineSteps
{
    [Binding]
    public class CompareSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public CompareSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User delete '(.*)' product from comparison")]
        public void WhenUserDeleteProductFromComparison(string productName)
        {
            var comparePage = new ComparePage();
            _driver.WaitForElementToBeDisplayed(comparePage.ComparsionHeader);
            comparePage.DeleteItemAddedToComparison(productName).Click();
        }

        [Then(@"User check that '(.*)' product that added to comparison is displayed")]
        public void ThenUserCheckThatProductThatAddedToComparisonIsDisplayed(string productName)
        {
            var comparePage = new ComparePage();
            _driver.WaitForElementToBeDisplayed(comparePage.ComparsionHeader);
            var someProduct = comparePage.ComparedItems.First(x => x.Text.Equals(productName));

            Assert.IsTrue(someProduct.Displayed, $"'{someProduct}' product is not displayed on comparison page");
        }

        [Then(@"User sees list of the market with prices for selected product")]
        public void ThenUserSeesListOfTheMarketWithPricesForSelectedProduct()
        {
            var itemPage = new ItemPage();
            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);

            Assert.IsTrue(itemPage.ListOfTheMarkets.Displayed, $"'{itemPage.ListOfTheMarkets}' is not displayed");
        }
    }
}
