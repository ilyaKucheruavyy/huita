using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;

namespace huita.GlobalSqaDatePickerPage
{
    class LocatorsForGlobalSqaDatePickerTests
    {

        [FindsBy(How = How.Id, Using = "menu-item-2822")]
        public IWebElement TestersHub { get; set; }

        [FindsBy(How = How.Id,Using = "menu-item-2823")]
        public IWebElement DemoTestingSite { get; set; }   
        
        [FindsBy(How = How.Id, Using = "menu-item-2827")]
        public IWebElement DatePickerMenu { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".hasDatepicker")]
        public IWebElement DatePickerField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".demo-frame.lazyloaded")]
        public IWebElement Frame { get; set; }  

        [FindsBy(How = How.CssSelector, Using = ".ui-datepicker-next.ui-corner-all")]
        public IWebElement ClickToNextMonth { get; set; }

        public string correctDay { get; } = DateTime.Now.ToString("d");
    }
}
