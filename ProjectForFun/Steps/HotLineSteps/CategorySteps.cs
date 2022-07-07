using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using TestProjectEtsy.Components;
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
        public void UserGoToAllCategories()
        {
            var mainPage = new MainPage();
            var categoryPage = new CategoryPage();
            mainPage.AllCategories.Click();
            _driver.WaitForElementToBeDisplayed(categoryPage.CategoryHeader);
        }

        [When(@"User choose category '(.*)'")]
        public void UserSearchCategory(string categoryName)
        {
            var autocomplete = new Autocomplete();
            autocomplete.GetParameterOnCategoryPage(categoryName).Click();
        }

        [Then(@"User sees category header")]
        public void UserSeesCategoryHeader()
        {
            var categoryPage = new CategoryPage();
            Assert.IsTrue(categoryPage.CategoryHeader.Displayed, $"Element {categoryPage.CategoryHeader} is not displayed");
        }
    }
}
