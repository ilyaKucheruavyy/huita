using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using NUnit.Framework;
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
            var mainPage = new MainPage();
            mainPage.AllCategories.Click();
        }

        [When(@"User select '(.*)' category by '(.*)' item name from autocomplete")]
        public void WhenUserSelectCategoryFromAutocomplete(string categoryName, string itemName)
        {
            var categoryPage = new CategoryPage();
            _driver.WaitForElementToBeDisplayed(categoryPage.CategoryHeader);
            categoryPage.SerchBarForCategory.SendKeys(itemName);
            categoryPage.GetOptionFromCategoryAutocomplete(categoryName).Click();
        }

        [Then(@"User sees category header")]
        public void ThenUserSeesCategoryHeader()
        {
            var categoryPage = new CategoryPage();
            Assert.IsTrue(categoryPage.CategoryHeader.Displayed, "Category header on 'search result' page is not displayed");
        }
    }
}
