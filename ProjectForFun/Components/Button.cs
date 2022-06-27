using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Button : BaseComponent
    {
        public IWebElement GetButtonByText(string buttonName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'modal__footer']//button[contains(text(),'{buttonName}')]"));
        }
    }
}
