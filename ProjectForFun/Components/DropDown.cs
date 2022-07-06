using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class DropDown : BaseComponent
    {
        public IWebElement GetOptionsDropdown(string dropdownIdentifier, string optionName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = '{dropdownIdentifier}']//option[contains(text(),'{optionName}')]"));
        }

        public IWebElement GetParameterDropdown(string dropdownId, string parameterName)
        {
            return Driver.FindElement(By.Xpath($".//div[@data-dropdown-id = '{dropdownId}']//li[contains(text(),'{parameterName}')]"));
        }
    }
}
