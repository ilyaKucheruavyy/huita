using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using TestProjectHotline.Components;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.BaseSteps
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
            var mainPage = _driver.GetPage<MainPage>();
            mainPage.SearchBar.SendKeys(itemName);
            mainPage.SubmitSearchButton.Click();
        }

        [When(@"User select '(.*)' option from '(.*)' dropdown")]
        public void WhenUserSelectOptionFromDropdown(string sortByName, string dropdownIdentifier)
        {
            var dropdown = new Dropdown();
            var searchResultPage = new SearchResultPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            dropdown.GetOptionsFromDropdown(dropdownIdentifier, sortByName).Click();
        }

        [When(@"User clicks button by identifier '(.*)'")]
        public void WhenUserClicksComparisonButtonByIdentifier(string identifier)
        {
            var button = new Button();
            button.GetButtonByClass(identifier).Click();
        }

        [When(@"User select '(.*)' option form dropdown by id '(.*)'")]
        public void WhenUserSelectOptionFromDropdownByID(string listName, string dropdownId)
        {
            var dropdown = new Dropdown();
            dropdown.GetOptionsFromDropdownByDropdownIdFromMainPage(dropdownId, listName).Click();
        }

        [When(@"User go to main page through the logo")]
        public void WhenUserGoToMainPageThroughTheLogo()
        {
            var mainPage = new MainPage();
            mainPage.HotlineLogo.Click();
        }

        [When(@"User go to 'personal list' from modal window")]
        public void WhenUserGoToPersonalListFromModalWindow()
        {
            var itemPage = new ItemPage();
            _driver.WaitForElementToBeDisplayed(itemPage.ModalWindowHeader);
            itemPage.GoToListFromModalWindow.Click();
        }

        [When(@"User clicks button ")]

        [When(@"User select '(.*)' option from dropdown by dropdown class '(.*)'")]
        public void WhenUserSelectOptionFromDropdownByDropdownClass(string optionName, string className)
        {
            var dropdown = new Dropdown();
            dropdown.GetOptionsFromDropdownByDropdownClass(className, optionName);
        }
    }
}
