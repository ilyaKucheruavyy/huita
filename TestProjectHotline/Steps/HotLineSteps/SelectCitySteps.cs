using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectHotline.Extensions;
using NUnit.Framework;
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
            var mainPage = new MainPage();
            mainPage.SelectCityButton.Click();
        }

        [When(@"User set '(.*)' city name to search bar")]
        public void WHenUserSetCityNameToSearchBar(string cityName)
        {
            var mainPage= new MainPage();
            _driver.WaitForElementToBeDisplayed(mainPage.SelectCityHeader);
            mainPage.SearchBarForSelectedCity.SendKeys(cityName);
        }

        [When(@"User select '(.*)' city")]
        public void WhenUserSelectCity(string cityName)
        {
            var mainPage = new MainPage();
            _driver.WaitForElementToBeDisplayed(mainPage.SelectCityHeader);
            mainPage.GetOptionFromSelectCityWindow(cityName).Click();
        }

        [Then(@"User sees 'select city' header")]
        public void ThenUserSeesSelectCityHeader()
        {
            var mainPage = new MainPage();
            Assert.IsTrue(mainPage.SelectCityHeader.Displayed, $"Element '{mainPage.SelectCityHeader}' is not displayed");
        }

        [Then(@"User sees '(.*)' city in geo tag")]
        public void ThenUserSeesCityInGeoTag(string cityName)
        {
            var mainPage = new MainPage();
            Assert.AreEqual(mainPage.SelectCityButton.Text, cityName, 
                $"Actual result '{mainPage.SelectCityButton.Text}' not equals to expected result '{cityName}'");
        }
    }
}
