using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using TechTalk.SpecFlow;
using TestProjectEtsy.Components;
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

        [When(@"User delete product '(.*)' from comparison")]
        public void UserDeleteProductFromComparsion(string productName)
        {
            var item = new Item();
            var comparePage = new ComparePage();
            _driver.WaitForElementToBeDisplayed(comparePage.ComparsionHeader);
            item.DeleteItemAddedToComparison(productName);
        }

        [Then(@"User check product '(.*)' added to comparison")]
        public void UserCheckProductAddedToComparison(string productName)
        {
            var comparePage = new ComparePage();
            _driver.WaitForElementToBeDisplayed(comparePage.ComparsionHeader);
            var anyProduct = comparePage.ComparedItems.First(x => x.Text == productName);

            Assert.IsTrue(anyProduct.Displayed, $"product {anyProduct} is not displayed on comparison page");
        }
    }
}
