using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using NUnit.Framework;
using System.Linq;
using TestProjectEtsy.Components;

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

        [When(@"User delete product '(.*)' from personal list")]
        public void UserDeleteProductFromPersonalList(string productName)
        {
            var item = new Item();
            var personalListPage = new PersonalListPage();
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);
            item.DeleteItemAddedToPersonalList(productName);
        }

        [Then(@"User check product '(.*)' added to personal list ")]
        public void UserCheckProductAddedToPersonalList(string productName)
        {
            var personalListPage = new PersonalListPage();
            var anyProduct = personalListPage.ProductAddedToPersonalList.First(x => x.Text == productName);
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);

            Assert.IsTrue(anyProduct.Displayed, $"Product {productName} is not displayed on personal list page");
        }
    }
}
