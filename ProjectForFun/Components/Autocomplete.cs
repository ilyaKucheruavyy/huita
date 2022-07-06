using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Autocomplete : BaseComponent
    {
        public IWebElement GetParameterOnChangeCityWindow(string cityName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'ui-menu-wrapper']//li[contains(text(),'{cityName}')]"));
        }

        public IWebElement GetParameterOnCategoryPage(string categoryName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'ui-menu-wrapper']//div[contains(text(),'{categoryName}')]"));
        }
    }
}
