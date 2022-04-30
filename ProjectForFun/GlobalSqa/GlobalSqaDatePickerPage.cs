using OpenQA.Selenium;
using huita.Helper;
using System;
using huita.Base;

namespace huita.GlobalSqa
{
    class GlobalSqaDatePickerPage : Driver
    {

        public GlobalSqaDatePickerPage (IWebDriver driver) : base(driver) { }

        private By TestersHub = By.Id("menu-item-2822");
        private By DemoTestingSite = By.Id("menu-item-2823");
        private By DatePickerMenu = By.Id("menu-item-2827");
        private By DatePickerField = By.CssSelector(".hasDatepicker");
        private By Frame = By.CssSelector(".demo-frame.lazyloaded");


        private By ClickToNextMonth = By.CssSelector(".ui-datepicker-next.ui-corner-all");
        private string correctDay = DateTime.Now.ToString("d");



        public void GoToDatePickermenu()
        {
            Utilits.MoveToElement(driver, TestersHub);
            Utilits.MoveToElement(driver, DemoTestingSite);
            driver.FindElement(DatePickerMenu).Click();
            driver.ScrollPage(0, 200);
            
            Utilits.SwitchFrame(driver,Frame);
            WebDriverExtensions.WaitElement(driver, DatePickerField, 10);
            driver.FindElement(DatePickerField).Click();
        }

        public void ChooseCorrectDate()
        {

            driver.FindElement(DatePickerField).Click();
            driver.FindElement(ClickToNextMonth).Click();
            driver.FindElement(DatePickerField).SendKeys(correctDay);
        }
    }
}
