using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using NUnit.Framework;

namespace TestProjectEtsy.Steps.HotLineSteps
{
    [Binding]
    public class CategorySteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public CategorySteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User go to all categories")]
        public void WhenUserGoToAllCategories()
        {
            var mainPage = new MainPage();
            mainPage.AllCategories.Click();
        }

        [When(@"User select '(.*)' category from autocomplete")]
        public void WhenUserSelectCategoryFromAutocomplete(string categoryName)
        {
            var categoryPage = new CategoryPage();
            _driver.WaitForElementToBeDisplayed(categoryPage.CategoryHeader);
            categoryPage.GetOptionFromCategoryAutocomplete(categoryName).Click();
        }

        [Then(@"User sees category header")]
        public void ThenUserSeesCategoryHeader()
        {
            var categoryPage = new CategoryPage();
            Assert.IsTrue(categoryPage.CategoryHeader.Displayed, $"Element '{categoryPage.CategoryHeader}' is not displayed");
        }
    }
}
