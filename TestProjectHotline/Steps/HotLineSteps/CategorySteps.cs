using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using TestProjectHotline.Components;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.HotLineSteps
{
    [Binding]
    public class CategorySteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public CategorySteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User go to 'all categories'")]
        public void WhenUserGoToAllCategories()
        {
            var actions = new Actions(_driver);
            var mainPage = _driver.GetPage<MainPage>();
            _driver.WaitForElementToBeDisplayed(mainPage.AllCategories);
            mainPage.MoveToAllCategories();
            

            mainPage.ClickOnAllCategory();
        }

        [When(@"User select '(.*)' category by '(.*)' item name from autocomplete")]
        public void WhenUserSelectCategoryFromAutocomplete(string categoryName, string itemName)
        {
            var categoryPage = _driver.GetPage<CategoryPage>();
            _driver.WaitForElementToBeDisplayed(categoryPage.CategoryHeader);
            categoryPage.SerchBarForCategory.SendKeys(itemName);
            _driver.WaitForElementToBeDisplayed(categoryPage.GetListOfCategory);
            categoryPage.GetOptionFromCategoryAutocomplete(categoryName).Click();
        }

        [Then(@"User sees category header")]
        public void ThenUserSeesCategoryHeader()
        {
            var searchResultPage = _driver.GetPage<SearchResultPage>();
            Assert.IsTrue(searchResultPage.CategoryTitle.Displayed, "Category header on 'search result' page is not displayed");
        }
    }
}
