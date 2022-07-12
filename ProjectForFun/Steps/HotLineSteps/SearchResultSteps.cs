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

        [When(@"User select '(.*)' manufacturer")]
        public void WhenUserSelectManufacturer(string manufacturerName)
        {
            var searchResultPage = new SearchResultPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            searchResultPage.ShowAllManufacturer.Click();
            searchResultPage.GetManufacturerFromSearchResultPage(manufacturerName).Click();
        }

        [When(@"User select '(.*)' category")]
        public void WhenUserSelectCategory(string categoryName)
        {
            var searchResultPage = new SearchResultPage();
            var categoryPage = new CategoryPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            categoryPage.GetCategoryFromSearchResultPage(categoryName).Click();
        }

        [When(@"User select '(.*)' sub-category")]
        public void WhenUserSelectSubCategory(string subCategoryName)
        {
            var searchResultPage = new SearchResultPage();
            var categoryPage = new CategoryPage();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            categoryPage.GetSubCategoryFromSearchResultPage(subCategoryName).Click();
        }

        [When(@"User select '(.*)' filter for product")]
        public void WhenUserSelectFilterForProduct(string filterName)
        {
            var searchResultPage = new SearchResultPage();
            var filtersMenu = new FiltersMenu();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            filtersMenu.GetFilterCheckbox(filterName).Click();
        }

        [When(@"User add '(.*)' product to 'compare'")]
        public void WhenUserAddProductToCompare(string productName)
        {
            var searchResultPage = new SearchResultPage();
            var compare = new Compare();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            compare.GetCompareCheckboxForItem(productName).Click(); 
        }

        [Then(@"User check that all displayed items has '(.*)' text in name")]
        public void ThenUserCheckThatAllDisplayedItemsHasTextInName(string productName)
        {
            var searchResultPage = new SearchResultPage();
            var actions = new Actions(_driver);
            var productsList = new List<IWebElement>();

            do
            {
                productsList.AddRange(searchResultPage.GetListOfTheFoundProduct());
                _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
                try
                {
                    actions.MoveToElement(searchResultPage.NextPageArrow).Perform();
                    searchResultPage.NextPageArrow.Click();
                }
                catch
                {
                    break;
                }
            }
            while (searchResultPage.NextPageArrow.Displayed);

            foreach (var product in productsList)
            {
                Assert.IsTrue(product.Text.Contains(productName), $"'{product}' product not contains '{productName}' in name");
            }
        }
    }
}
