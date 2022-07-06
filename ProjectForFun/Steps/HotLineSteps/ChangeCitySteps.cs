using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using TestProjectEtsy.Components;
using NUnit.Framework;

namespace TestProjectEtsy.Steps.HotLineSteps
{
    [Binding]
    public class ChangeCitySteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public ChangeCitySteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User change city")]
        public void UserChangeCity()
        {
            var mainPage = new MainPage();

            mainPage.ChangeCityButton.Click();
            _driver.WaitForElementToBeDisplayed(mainPage.ChangeCityHeader);
        }

        [When(@"User choose city '(.*)'")]
        public void UserChooseCity(string cityName)
        {
            var autocmplete = new Autocomplete();

            autocmplete.GetParameterOnChangeCityWindow(cityName).Click();
        }

        [Then(@"User sees change city header")]
        public void UserSeesChangeCityHeader()
        {
            var mainPage = new MainPage();

            Assert.IsTrue(mainPage.ChangeCityHeader.Displayed, $"Element {mainPage.ChangeCityHeader} is not displayed");
        }

        [Then(@"User sees changed city name '(.*)'")]
        public void UserSeesChangedCityName(string cityName)
        {
            var mainPage = new MainPage();

            Assert.AreEqual(mainPage.ChangeCityButton.Text, cityName, 
                $"Actual result {mainPage.ChangeCityButton.Text} is not equal expected result {cityName}");
        }
    }
}
