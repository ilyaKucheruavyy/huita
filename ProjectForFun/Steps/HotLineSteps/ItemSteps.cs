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

        [When(@"User clicks 'compare price' button")]
        public void WhenUserClicksComparePriceButton()
        {
            var itemPage = new ItemPage();
            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.ComparePriceButton.Click();
        }

        [When(@"User add product to compare")]
        public void WhenUserAddProductToCompare()
        {
            var itemPage = new ItemPage();
            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.AddToCompareButton.Click();
        }

        [When(@"User go to personal list")]
        public void WhenUserGoToPersonalList()
        {
            var itemPage = new ItemPage();
            itemPage.GoTolist.Click();
        }
    }
}
