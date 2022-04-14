using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace huita.Helper
{
    public static class WebDriverExtensions
    {
        public static void WaitElement(this IWebDriver driver, int second)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(second);

        }

        public static void WaitElement(this IWebDriver driver, By locator, int second)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(driver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementToBeClickable(locator));
            new WebDriverWait(driver, TimeSpan.FromSeconds(second)).Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void InputSomeText(this IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text); 
            Actions actions = new(driver);
            actions.SendKeys(Keys.Enter).Perform(); 
        }

        public static void ScrollDown(this IWebDriver driver, int xLine, int yLine)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"window.scrollBy({xLine}, {yLine})");
        }

        public static void CLICK(this IWebDriver driver, By someElement)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", someElement);
        }
    }
}
