using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Components;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestProjectEtsy.Steps.HotLineSteps
{
    [Binding]
    public class SearchResultSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public SearchResultSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User choose manufacturer '(.*)'")]
        public void UserChooseManufacturer(string manufacturerName)
        {
            var searchResultPage = new SearchResultPage();
            var manufacturer = new Manufacturer();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            searchResultPage.ShowAllManufacturer.Click();
            manufacturer.GetManufacturerOnSearchResultPage(manufacturerName);
        }

        [When(@"User choose category '(.*)'")]
        public void UserChooseCategory(string categoryName)
        {
            var searchResultPage = new SearchResultPage();
            var category = new Category();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            category.GetCategoryOnSearchresultPage(categoryName);
        }

        [When(@"User choose sub-category '(.*)'")]
        public void UserChooseSubCategory(string subCategoryName)
        {
            var searchResultPage = new SearchResultPage();
            var category = new Category();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            category.GetSubCategoryOnSearchresultPage(subCategoryName);
        }

        [When(@"User choose filter '(.*)' for product")]
        public void UserChooseFilterForProduct(string filterName)
        {
            var searchResultPage = new SearchResultPage();
            var filtersMenu = new FiltersMenu();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            filtersMenu.GetFilterCheckbox(filterName);
        }

        [Then(@"User add product '(.*)' to compare")]
        public void UserAddProductToCompare(string productName)
        {
            var searchResultPage = new SearchResultPage();
            var compare = new Compare();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            compare.GetCompareCheckboxForItem(productName);
        }

        [When(@"User check found product '(.*)'")]
        public void UserCheckFoundProduct(string productName)
        {
            var searchResultPage = new SearchResultPage();
            var actions = new Actions(_driver);
            var productsList = new List<IWebElement>();

            do
            {
                productsList.AddRange(searchResultPage.GetListFoundProduct());
                _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
                try
                {
                    actions.MoveToElement(searchResultPage.NextPage).Perform();
                    searchResultPage.NextPage.Click();

                }
                catch
                {
                    break;
                }
            }
            while (searchResultPage.NextPage.Displayed);

            foreach (var product in productsList)
            {
                Assert.IsTrue(product.Text.Contains(productName));
            }
        }
    }
}
