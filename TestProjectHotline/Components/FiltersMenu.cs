using OpenQA.Selenium;

namespace TestProjectHotline.Components
{
    public class FiltersMenu: BaseComponent
    {
        public IWebElement GetFilterCheckbox(string filterName)
        {
            return Driver.FindElement(By.XPath
                ($".//div[@class = 'sidebar-filter__body']//div[contains(text(),'{filterName}')]//preceding-sibling::input"));
        }
    }
}
