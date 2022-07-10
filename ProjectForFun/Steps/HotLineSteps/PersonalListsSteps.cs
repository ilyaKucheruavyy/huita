using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using NUnit.Framework;
using System.Linq;

namespace TestProjectEtsy.Steps.HotLineSteps
{
    [Binding]
    public class PersonalListsSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public PersonalListsSteps (WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User delete '(.*)' product from personal list")]
        public void WhenUserDeleteProductFromPersonalList(string productName)
        {
            var personalListPage = new PersonalListPage();
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);
            personalListPage.DeleteItemAddedToPersonalList(productName);
        }

        [Then(@"User check that '(.*)' product added to personal list is displayed")]
        public void ThenUserCheckThatProductAddedToPersonalListIsDisplayed(string productName)
        {
            var personalListPage = new PersonalListPage();
            var anyProduct = personalListPage.ProductAddedToPersonalList.First(x => x.Text.Equals(productName));
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);

            Assert.IsTrue(anyProduct.Displayed, $"{productName} product is not displayed on personal list page");
        }
    }
}
