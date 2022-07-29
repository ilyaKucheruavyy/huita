using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.HotLineSteps
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
            var itemPage = _driver.GetPage<ItemPage>();
            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.ComparePriceButton.Click();
        }

        [When(@"User add selected product to 'compare'")]
        public void WhenUserAddSelectedProductToCompare()
        {
            var itemPage = _driver.GetPage<ItemPage>();
            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.AddToCompareButton.Click();
        }

        [When(@"User go to 'personal list'")]
        public void WhenUserGoToPersonalList()
        {
            var itemPage = _driver.GetPage<ItemPage>();
            itemPage.GoTolist.Click();
        }

        [When(@"User add selected product to 'personal list'")]
        public void WhenUserAddSelectedProductToPersonalList()
        {
            var itemPage = _driver.GetPage<ItemPage>();
            _driver.WaitForElementToBeDisplayed(itemPage.ItemPageHeader);
            itemPage.HeartShapedIcon.Click();
        }
    }
}
