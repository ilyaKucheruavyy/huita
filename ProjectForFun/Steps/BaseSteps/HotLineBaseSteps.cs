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

        [When(@"User clicks '(.*)' product from search result page")]
        public void WhenUserClicksProductFormSearchResultPage(string productName)
        {
            var searchResultPage = new SearchResultPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            searchResultPage.GоToProductFromSearchResultPage(productName).Click();
        }

        [When(@"User set '(.*)' text to search bar")]
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
            dropdown.GetOptionsFromDropdown(dropdownIdentifier, sortByName);
        }

        [When(@"User clicks button 'my list'")]
        public void WhenUserClicksButtonMyList()
        {
            var mainPage = new MainPage();
            mainPage.GoToMyListsButton.Click();

        }

        [When(@"User clicks button 'comparison'")]
        public void WhenUserClicksButtonComparison()
        {
            var mainPage = new MainPage();
            mainPage.GoToComparisonButton.Click();
        }

        [When(@"User select '(.*)' option on dropdown by id '(.*)'")]
        public void WhenUserChooseListOnDropdownByID(string listName, string dropdownId)
        {
            var dropdown = new Dropdown();
            dropdown.GetOptionsDropdownByDropdownId(dropdownId, listName);
        }

        [When(@"User go to main page through the logo")]
        public void WhenUserGoToMainMenuThroughTheLogo()
        {
            var mainPage = new MainPage();
            mainPage.HotlineLogo.Click();
        }
    }
}
