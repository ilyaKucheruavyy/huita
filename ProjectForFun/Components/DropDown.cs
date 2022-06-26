using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class DropDown : BaseComponent
    {
        public IWebElement GetOptionsDropDown(string dropdownIdentifier, string optionName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = '{dropdownIdentifier}']//option[contains(text(),'{optionName}')]"));
        }
    }
}
