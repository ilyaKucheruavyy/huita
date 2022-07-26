using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V103.IndexedDB;
using OpenQA.Selenium.Interactions;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.HotLineSteps
{
    [Binding]
    public class SelectCitySteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public SelectCitySteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks 'select city' button")]
        public void WhenUserClicksSelectCityButton()
        {
            var selectCityPage = _driver.GetPage<SelectCityPage>();
            selectCityPage.SelectCityButton.Click();
        }

        [When(@"User set '(.*)' city name to search bar")]
        public void WHenUserSetCityNameToSearchBar(string cityName)
        {
            var selectCityPage = _driver.GetPage<SelectCityPage>();
            _driver.WaitForElementToBeDisplayed(selectCityPage.SelectCityHeader);
            selectCityPage.SearchBarForCity.SendKeys(cityName);
        }

        [When(@"User select '(.*)' city")]
        public void WhenUserSelectCity(string cityName)
        {
            var actions = new Actions(_driver);
            var selectCityPage = _driver.GetPage<SelectCityPage>();
            actions.MoveToElement(selectCityPage.GetOptionFromSelectCityAutocomplete(cityName)).Click().Perform();
        }

        //[When(@"User select '(.*)' city by '(.*)' city name from autocomplete")]
        //public void WhenUserSelectCategoryFromAutocomplete(string city, string cityName)
        //{
        //    var selectCityPage = _driver.GetPage<SelectCityPage>();
        //    _driver.WaitForElementToBeDisplayed(selectCityPage.SelectCityHeader);
        //    selectCityPage.SearchBarForCity.SendKeys(cityName);
        //    _driver.WaitForElementToBeDisplayed(selectCityPage.GetListOfCity);
        //    selectCityPage.GetOptionFromSelectCityAutocomplete(city).Click();
        //}

        [Then(@"User sees 'select city' header")]
        public void ThenUserSeesSelectCityHeader()
        {
            var selectCityPage = _driver.GetPage<SelectCityPage>();
            Assert.IsTrue(selectCityPage.SelectCityHeader.Displayed, $"Element '{selectCityPage.SelectCityHeader}' is not displayed");
        }

        [Then(@"User sees '(.*)' city in geo tag")]
        public void ThenUserSeesCityInGeoTag(string cityName)
        {
            var selectCityPage = _driver.GetPage<SelectCityPage>();
            Assert.AreEqual(selectCityPage.SelectCityButton.Text, cityName, 
                $"Actual result '{selectCityPage.SelectCityButton.Text}' not equals to expected result '{cityName}'");
        }
    }
}
