using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace huita.Helper
{
    public static class WebDriverExtensions
    {
        public static void WaitElement(this IWebDriver driver, int second)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(second);

        }

        public static void WaitElement(this IWebDriver driver, IWebElement locator, int second)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementIsVisible((By)locator));
            new WebDriverWait(driver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void InputSomeText(this IWebDriver driver, IWebElement locator, string text)
        {
            locator.SendKeys(text); 
            Actions actions = new(driver);
            actions.SendKeys(Keys.Enter).Perform(); 
        }

        public static void ScrollPage(this IWebDriver driver, int xLine, int yLine)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollBy({xLine}, {yLine})");
        }
    }
}
