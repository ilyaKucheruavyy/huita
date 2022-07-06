using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;

namespace TestProjectEtsy.Steps.HotLineSteps
{
    [Binding]
    public class ItemSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public ItemSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User click on 'compare price' button")]
        public void UserClickOnComparePriceButton()
        {
            var itemPage = new ItemPage();

            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.ComparePriceButton.Click();
        }

        [When(@"User add product to compare)'")]
        public void UserAddProductToCompare()
        {
            var itemPage = new ItemPage();

            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.AddToCompareButton.Click();
        }

        [When(@"User go to personal list")]
        public void UserGoToPersonalList()
        {
            var itemPage = new ItemPage();
            var personalListPage = new PersonalListPage();

            itemPage.GoTolist.Click();
            _driver.WaitForElementToBeDisplayed(personalListPage.PersonalListHeader);
        }
    }
}
