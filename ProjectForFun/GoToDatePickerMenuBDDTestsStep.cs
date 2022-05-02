using huita.Base;
using huita.Helper;
using OpenQA.Selenium;
using huita.GlobalSqaDatePickerPage;
using TechTalk.SpecFlow;

namespace huita
{
    [Binding]
    public class GoToDatePickerMenuBDDTestsStep : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public GoToDatePickerMenuBDDTestsStep(WebDriver driver)
        {
            _driver = driver;
        }

        LocatorsForGlobalSqaDatePickerTests globalSqa = new();

        [Given(@"User go to GlobalSqa")]
        public void GivenUserGoToGlobalSqa()
        {
            var baseUrl = "https://www.globalsqa.com/";

            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();
        }

        [When(@"User go to datepicker menu")]
        public void WhenUserGoToDatePickerMenu()
        {
            Utilits.MoveToElement(_driver, globalSqa.TestersHub);
            Utilits.MoveToElement(_driver, globalSqa.DemoTestingSite);
            (globalSqa.DatePickerMenu).Click();
            _driver.ScrollPage(0, 200);

            Utilits.SwitchFrame(_driver, globalSqa.Frame);
            _driver.WaitForElementToBeDisplayed(globalSqa.DatePickerField);
            (globalSqa.DatePickerField).Click();
        }

        [When (@"User choose correct date")]
        public void WhenUserChooseCorrectDate()
        {
            (globalSqa.DatePickerField).Click();
            (globalSqa.ClickToNextMonth).Click();
            (globalSqa.DatePickerField).SendKeys(globalSqa.correctDay);
        }
    }
}
