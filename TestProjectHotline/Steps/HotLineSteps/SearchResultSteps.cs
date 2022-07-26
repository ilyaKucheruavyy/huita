using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using NUnit.Framework;
using TestProjectHotline.Components;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.HotLineSteps
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
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            try
            {
                searchResultPage.ShowAllManufacturer.Click();
            }
            catch
            {
                searchResultPage.GetManufacturerFromSearchResultPage(manufacturerName);
            }
        }

        [When(@"User select '(.*)' category")]
        public void WhenUserSelectCategory(string categoryName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            var categoryPage = _driver.GetPage<CategoryPage>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            categoryPage.GetCategoryFromSearchResultPage(categoryName).Click();
        }

        [When(@"User select '(.*)' sub-category")]
        public void WhenUserSelectSubCategory(string subCategoryName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            var categoryPage = _driver.GetPage<CategoryPage>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
            categoryPage.GetSubCategoryFromSearchResultPage(subCategoryName).Click();
        }

        [When(@"User select '(.*)' filter for product")]
        public void WhenUserSelectFilterForProduct(string filterName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            var filtersMenu = _driver.GetComponent<FiltersMenu>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            filtersMenu.GetFilterCheckbox(filterName);
        }

        [When(@"User add '(.*)' product to 'compare'")]
        public void WhenUserAddProductToCompare(string productName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            var compare = _driver.GetComponent<Compare>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.CategoryTitle);
            compare.GetCompareCheckboxForItem(productName);
        }

        [Then(@"User check that all displayed items has '(.*)' text in name")]
        public void ThenUserCheckThatAllDisplayedItemsHasTextInName(string productName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            var actions = new Actions(_driver);
            var productList = new List<string>();

            while (searchResultPage.NextPageArrow.Displayed)
            {
                _driver.WaitForElementToBeDisplayed(searchResultPage.SearchResultTitle);
                try
                {
                    productList.AddRange(searchResultPage.GetListOfTheFoundProduct());
                    actions.MoveToElement(searchResultPage.NextPageArrow).Perform();
                    searchResultPage.NextPageArrow.Click();
                    var nextPageArrowDisplayed = searchResultPage.NextPageArrow.Displayed;
                }
                catch
                {
                    break;
                }
            }

            foreach (var product in productList)
            {
                Assert.IsTrue(product.Contains(productName), $"'{product}' product not contains '{productName}' in name");
            }
        }

        [Then(@"User sees '(.*)' option for sorting selected previously")]
        public void ThenUserSeesOptionForSortingSelectedPreviously(string optionName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            Assert.IsTrue(searchResultPage.GetSortedByOption(optionName).Selected, "Selected another option");
        }

        [When(@"User go to 'selected filters'")]
        public void WhenUserGoToSelectedFilters()
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            searchResultPage.SelectedFilters.Click();
        }

        [Then(@"User check that selected '(.*)' filter is displayed")]
        public void ThenUserCheckThatSelectedFilterIsDisplayed(string filterName)
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            _driver.WaitForElementToBeDisplayed(searchResultPage.SelectedFiltersTitle);
            var selectedFilter = searchResultPage.GetSelectedFilters(filterName);

            Assert.IsTrue(selectedFilter.Displayed, "Filter not displayed");
        }
    }
}