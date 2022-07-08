using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Manufacturer : BaseComponent
    {
        public IWebElement GetManufacturerOnSearchResultPage(string manufacturerName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[@class = 'search-sidebar-filter search-sidebar__item content']//div[@class = 'search-sidebar-checklist__item-name link link--black' and contains(text(),'{manufacturerName}')]/preceding-sibling::input"));
        }
    }
}