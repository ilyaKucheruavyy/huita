using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class ButtonComponents
    {
        private readonly WebDriver _driver;

        public ButtonComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ButtonByAriaLabel(string text)
        {
            return _driver.FindElement(By.XPath($".//button[@aria-label = '{text}']"));
        }
    }
}
