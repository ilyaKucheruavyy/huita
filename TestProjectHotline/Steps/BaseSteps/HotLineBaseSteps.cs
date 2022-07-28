using OpenQA.Selenium;
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
            var itemPage = _driver.GetPage<ItemPage>();
            var button = _driver.GetComponent<Button>();
            _driver.WaitForElementToBeDisplayed(itemPage.ModalWindowHeader);
            button.GetButtonByText(buttonName).Click();
        }

        [When(@"User clicks '(.*)' product from 'search result' page")]
        public void WhenUserClicksProductFromSearchResultPage(string productName)
        {
            var searchResultPage =_driver.GetPage<SearchResultPage>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            searchResultPage.GetProductFromSearchResultPage(productName).Click();
        }

        [When(@"User set '(.*)' text to 'search bar'")]
        public void WhenUserSetTextToSearchBar(string itemName)
        {
            var mainPage = _driver.GetPage<MainPage>();
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            mainPage.SearchBar.SendKeys(itemName);
            mainPage.SubmitSearchButton.Click();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
        }

        [When(@"User select '(.*)' option from '(.*)' dropdown")]
        public void WhenUserSelectOptionFromDropdown(string sortByName, string dropdownIdentifier)
        {
            var dropdown = _driver.GetComponent<Dropdown>();
            dropdown.GetOptionsFromDropdown(dropdownIdentifier, sortByName).Click();
        }

        [When(@"User clicks button by identifier '(.*)'")]
        public void WhenUserClicksButtonByIdentifier(string identifier)
        {
            var button = _driver.GetComponent<Button>();
            button.GetButtonByClass(identifier).Click();
        }

        [When(@"User select '(.*)' option form dropdown by id '(.*)'")]
        public void WhenUserSelectOptionFromDropdownById(string listName, string dropdownId)
        {
            var dropdown = _driver.GetComponent<Dropdown>();
            dropdown.GetOptionsFromDropdownByIdFromMainPage(dropdownId, listName).Click();
        }

        [When(@"User go to main page through the logo")]
        public void WhenUserGoToMainPageThroughTheLogo()
        {
            var mainPage = _driver.GetPage<MainPage>();
            mainPage.HotlineLogo.Click();
        }

        [When(@"User go to 'personal list' from modal window")]
        public void WhenUserGoToPersonalListFromModalWindow()
        {
            var itemPage = _driver.GetPage<ItemPage>();
            itemPage.GoToListFromModalWindow.Click();
            _driver.SwitchToNewWindow();
        }

        [When(@"User select '(.*)' option from dropdown by class '(.*)'")]
        public void WhenUserSelectOptionFromDropdownByClass(string optionName, string className)
        {
            var dropdown = _driver.GetComponent<Dropdown>() ;
            dropdown.GetOptionsFromDropdownByClass(className, optionName).Click();
            _driver.SwitchToNewWindow();
        }
    }
}
