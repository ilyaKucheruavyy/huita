using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Compare : BaseComponent
    {
        public IWebElement GetCompareCheckboxForItem(string productName)
        {
            return Driver.FindElement
            (By.XPath
                ($".//a[contains(text(),'{productName}')]//..//..//preceding-sibling::div//input"));
        }
    }
}