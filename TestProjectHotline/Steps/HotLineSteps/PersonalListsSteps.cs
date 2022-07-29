using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using NUnit.Framework;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.HotLineSteps
{
    [Binding]
    public class PersonalListsSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public PersonalListsSteps (WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User delete '(.*)' product from 'personal list'")]
        public void WhenUserDeleteProductFromPersonalList(string productName)
        {
            var personalListPage = _driver.GetPage<PersonalListPage>();
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);
            personalListPage.GetIconForDeleteItemFromPersonalList(productName).Click();
        }

        [Then(@"User check that '(.*)' product that added to personal list is displayed")]
        public void ThenUserCheckThatProductThatAddedToPersonalListIsDisplayed(string productName)
        {
            var personalListPage = _driver.GetPage<PersonalListPage>();
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);

            Assert.IsTrue(personalListPage.GetProductAddedToPersonalList(productName).Displayed,$"'{productName}' product is not displayed on personal list page");
        }
    }
}
