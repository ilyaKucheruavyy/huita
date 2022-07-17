using System.Linq;
using OpenQA.Selenium;

namespace TestProjectHotline.Components
{
    public class Dropdown : BaseComponent
    {
        public IWebElement GetOptionsFromDropdown(string dropdownIdentifier, string optionName)
        {
            return Driver.FindElement(By.XPath($".//div[contains(@class,'{dropdownIdentifier}')]//option[contains(text(),'{optionName}')]"));
        }

        public IWebElement GetOptionsFromDropdownByDropdownIdFromMainPage(string dropdownId, string parameterName)
        {
            return Driver.FindElement(By.XPath($".//div[@data-dropdown-id = '{dropdownId}']//li[contains(text(),'{parameterName}')]"));
        }

        public IWebElement GetOptionsFromDropdownByDropdownClass(string dropdownId, string optionName)
        {
            return Driver.FindElements(By.XPath($".//div[contains(@class, 'item-{dropdownId}')]//a"))
                .First(x => x.Text.Equals(optionName));
        }
    }
}
