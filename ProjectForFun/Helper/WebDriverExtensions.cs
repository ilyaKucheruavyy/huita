using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;

namespace huita.Helper
{
    public static class WebDriverExtensions
    {
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

        public static void WaitForElementToBeDisplayed(this IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ElementIsInDisplayedCondition(element, true));
            // тут, антил, будет ждать 15 секунд, бо так сетнуто выше в вебДрайверВейт, на предмет того, что елемент все таки откинет тру, ну то есть будет виден
            // если закинуть фолс, метод будет ждать, что в течении 15 секунд, елемент пропадёт
        }

        public static void WaitForElementToBeDisplayed(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            // я бы использовал в этом проекте этот вейтер, бо если честно, редко бывают ситуации, когда ты получил уже вебЕлемент, но он меняет свой дисплейд стейтмент
        }

        private static Func<IWebDriver, bool> ElementIsInDisplayedCondition(IWebElement element, bool displayedCondition) // для драйвера здорово 
        {
            return (driver) =>
            {
                try
                {
                    // тут короче прокинул ретур стейт, который тупо чекает, елемент дисплейд или нет здарова ебать
                    return element.Displayed.Equals(displayedCondition);
                }
                catch (Exception e)
                {
                    // собсна если нет, то вернется фолс
                    return false.Equals(displayedCondition);
                }
            };
        }

    }
}
