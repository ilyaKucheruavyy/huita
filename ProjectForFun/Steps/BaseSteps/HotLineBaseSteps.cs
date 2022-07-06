using OpenQA.Selenium;
using System.Threading;
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

        [When(@"User click button '(.*)' in modal wimdow")]
        public void UserClickButtonInModalWindow(string buttonName)
        {
            var itemPage = new ItemPage();
            var button = new Button();

            _driver.WaitForElementToBeDisplayed(itemPage.ModalWindowHeader);
            button.GetButtonByText(buttonName).Click();
        }

        [When(@"User click on product '(.*)' on search result page")]
        public void UserClickOnProductOnSearchResultPage(string productName)
        {
            var item = new Item();
            var searchResultPage = new SearchResultPage();

            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            item.GetToProductOnSearchResultPage(productName).Click();
        }

        [When(@"User use search bar '(.*)' for searching item '(.*)'")]
        public void UserSearchItem(string placeholderIdentifier, string itemName)
        {
            var searchBar = new SearchBar();

            searchBar.SearchBarByPlaceHolder(placeholderIdentifier).SendKeys(itemName);
        }

        [When(@"User choose parameter '(.*)' on dropdown '(.*)'")]
        public void UserChooseParameterOnDropdown(string sortByName, string dropdownIdentifier)
        {
            var dropdown = new DropDown();
            var searchResultPage = new SearchResultPage();

            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            dropdown.GetOptionsDropdown(dropdownIdentifier, sortByName);
        }

        [When(@"User click on 'my list'")]
        public void UserClickOnMyList()
        {
            var personalListPage = new PersonalListPage();

            personalListPage.GoToMyListsButton.Click();
            Thread.Sleep(500);
        }

        [When(@"User click on 'comparsion'")]
        public void UserClickOnComprasion()
        {
            var comparePage = new ComparePage();

            comparePage.GoToComparisonButton.Click();
            Thread.Sleep(500);
        }

        [When(@"User choose list '(.*)' on dropdown '(.*)'")]
        public void UserChooseListOnDropdown(string listName, string dropdownId)
        {
            var dropdown = new DropDown();

            dropdown.GetParameterDropdown(dropdownId, listName);
        }
    }
}
