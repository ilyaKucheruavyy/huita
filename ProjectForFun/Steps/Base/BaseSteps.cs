using System;
using huita.Helper;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace huita.Steps.Base
{
    [Binding]
    class BaseSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public BaseSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"User is on '(.*)'")]
        public void GivenUserIsOn(string urlIdentifier)
        {
            string baseUrl = urlIdentifier switch
            {
                "etsy" => baseUrl = "https://www.etsy.com/",
                "globalSqa" => baseUrl = "https://www.globalsqa.com/",
                _ => throw new Exception($"Environment with name '{urlIdentifier}' doesn't exist")
            };
            _driver.Navigate().GoToUrl(baseUrl);
        }

        [When(@"Navigate to datepicker menu")]
        public void GoToDatePickermenu()
        {
            var TestersHub = By.Id("menu-item-2822");
            var DemoTestingSite = By.Id("menu-item-2823");
            var DatePickerMenu = By.Id("menu-item-2827");
            var DatePickerField = By.CssSelector(".hasDatepicker");
            var Frame = By.CssSelector(".demo-frame.lazyloaded");

            Utilits.MoveToElement(_driver, TestersHub);
            Utilits.MoveToElement(_driver, DemoTestingSite);
            _driver.FindElement(DatePickerMenu).Click();
            _driver.ScrollDown(0, 200);

            Utilits.SwitchFrame(_driver, Frame);
            WebDriverExtensions.WaitElement(_driver, DatePickerField, 10);
            _driver.FindElement(DatePickerField).Click();
        }
    }
}