using OpenQA.Selenium;

namespace TestProjectHotline.Components
{
    public class Button : BaseComponent
    {
        public IWebElement GetButtonByText(string buttonName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'modal__footer']//button[contains(text(),'{buttonName}')]"));
        }

        public IWebElement GetButtonByClass(string identifier)
        {
            return Driver.FindElement(By.XPath($".//div[contains(@class, 'item-{identifier}')]"));
        }
    }
}
