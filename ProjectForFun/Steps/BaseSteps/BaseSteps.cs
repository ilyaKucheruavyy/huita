using System;
using huita.Helper;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace huita.Steps.BaseSteps
{
    [Binding]
    public class BaseSteps : SpecFlowContext
    {
        private readonly WebDriver driver;

        public BaseSteps(WebDriver _driver)
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
            driver.Navigate().GoToUrl(baseUrl);
        }

        [When(@"Navigate to datepicker menu")]
        public void GoToDatePickermenu()
        {
            var TestersHub = By.Id("menu-item-2822");
            var DemoTestingSite = By.Id("menu-item-2823");
            var DatePickerMenu = By.Id("menu-item-2827");
            var DatePickerField = By.CssSelector(".hasDatepicker");
            var Frame = By.CssSelector(".demo-frame.lazyloaded");

            Utilits.MoveToElement(driver, TestersHub);
            Utilits.MoveToElement(driver, DemoTestingSite);
            driver.FindElement(DatePickerMenu).Click();
            driver.ScrollDown(0, 200);

            Utilits.SwitchFrame(driver, Frame);
            WebDriverExtensions.WaitElement(driver, DatePickerField, 10);
            driver.FindElement(DatePickerField).Click();
        }
    }
}