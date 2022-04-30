using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace huita.Helper
{
    public static class Utilits
    { 
        public static void SelectSomeElementByValue(IWebDriver driver, By locator, string value)
        {
            SelectElement selectElement = new(driver.FindElement(locator));
            selectElement.SelectByValue(value);
        }

        public static void SwitchFrame(IWebDriver driver, By locator)
        {
            IWebElement frame = driver.FindElement(locator);
            driver.SwitchTo().Frame(frame); 
        }

        public static void MoveToElementAndClick(IWebDriver driver, By locator)
        {
            var actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(locator))
                .Click()
                .Perform();
        }

        public static void MoveToElement(IWebDriver driver, By locator)
        {
            Actions actions = new (driver);
            actions.MoveToElement(driver.FindElement(locator))
                .Perform();
        }


        public static void SwitchToNewWindow(IWebDriver driver)
        {
            var newPageHandles = driver.WindowHandles;

            foreach (var handle in newPageHandles)
            {
                List<string> oldHandles = new List<string>();

                if (!oldHandles.Contains(handle))
                {
                    driver.SwitchTo().Window(handle);
                }
            }
        }

        public static void SortedBySomeWorld(IWebDriver driver, By locator, string sortedAllBy)
        {

            var SortedBy = driver.FindElements(locator)
                .First(x => x.Text == sortedAllBy);
            SortedBy.Click(); 
        }

        public static void WhenUserSelectCheckbox(IWebDriver driver, string checkboxIdentifier)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           js.ExecuteScript($"var a = document.evaluate('{checkboxIdentifier}', document).iterateNext(); a.click();");
        }

        public static void ScrollToElementWithJS(IWebDriver driver, string selector)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)(driver);
            js.ExecuteScript($"var selectCounry = document.querySelector('{selector}'); selectCounry.scrollIntoView(false);");
        }
    }
}
