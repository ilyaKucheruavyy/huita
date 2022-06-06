using OpenQA.Selenium;

namespace huita.Components
{
    public class ButtonByAriaLabelComponents
    {
        private readonly WebDriver _driver;

        public ButtonByAriaLabelComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ButtonByAriaLabel(string text)
        {
            return _driver.FindElement(By.XPath($".//button[@aria-label = '{text}']"));
        }
    }
}
