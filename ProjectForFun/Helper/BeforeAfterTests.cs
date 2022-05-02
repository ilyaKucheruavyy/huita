using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using huita.Base;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace huita.Helper
{
    public class BeforeAfterTests : Driver
    {
        public BeforeAfterTests(WebDriver driver) : base(driver) { }


        [AfterScenario(Order = 100000)]
        public void QuitDriver()
        {
            driver.Close();
        }
    }
}
