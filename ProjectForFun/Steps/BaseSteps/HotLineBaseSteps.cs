using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Components;
using TestProjectEtsy.Extensions;
using TestProjectEtsy.Pages;

namespace TestProjectEtsy.Steps.BaseSteps
{
    [Binding]
    public class HotLineBaseSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public HotLineBaseSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks '(.*)' button in modal window")]
        public void WhenUserClicksButtonInModalWindow(string buttonName)
        {
            var itemPage = new ItemPage();
            var button = new Button();
            _driver.WaitForElementToBeDisplayed(itemPage.ModalWindowHeader);
            button.GetButtonByText(buttonName).Click();
        }

        [When(@"User clicks '(.*)' product from 'search result' page")]
        public void WhenUserClicksProductFromSearchResultPage(string productName)
        {
            var searchResultPage = new SearchResultPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            searchResultPage.GоToProductFromSearchResultPage(productName).Click();
        }

        [When(@"User set '(.*)' text to 'search bar'")]
        public void WhenUserSetTextToSearchBar(string itemName)
        {
            var mainPage = new MainPage();
            mainPage.SearchBar.SendKeys(itemName);
        }

        [When(@"User select '(.*)' option from '(.*)' dropdown")]
        public void WhenUserSelectOptionFromDropdown(string sortByName, string dropdownIdentifier)
        {
            var dropdown = new Dropdown();
            var searchResultPage = new SearchResultPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            dropdown.GetOptionsFromDropdown(dropdownIdentifier, sortByName).Click();
        }

        [When(@"User clicks 'my list' button")]
        public void WhenUserClicksMyListButton()
        {
            var mainPage = new MainPage();
            mainPage.GoToMyListsButton.Click();
        }

        [When(@"User clicks 'comparison' button")]
        public void WhenUserClicksComparisonButton()
        {
            var mainPage = new MainPage();
            mainPage.GoToComparisonButton.Click();
        }

        [When(@"User select '(.*)' option form dropdown by id '(.*)'")]
        public void WhenUserSelectOptionFromDropdownByID(string listName, string dropdownId)
        {
            var dropdown = new Dropdown();
            dropdown.GetOptionsFromDropdownByDropdownId(dropdownId, listName).Click();
        }

        [When(@"User go to main page through the logo")]
        public void WhenUserGoToMainPageThroughTheLogo()
        {
            var mainPage = new MainPage();
            mainPage.HotlineLogo.Click();
        }
    }
}
