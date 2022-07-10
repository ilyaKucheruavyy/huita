using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Dropdown : BaseComponent
    {
        public IWebElement GetOptionsFromDropdown(string dropdownIdentifier, string optionName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = '{dropdownIdentifier}']//option[contains(text(),'{optionName}')]"));
        }

        public IWebElement GetOptionsDropdownByDropdownId(string dropdownId, string parameterName)
        {
            return Driver.FindElement(By.XPath($".//div[@data-dropdown-id = '{dropdownId}']//li[contains(text(),'{parameterName}')]"));
        }
    }
}
