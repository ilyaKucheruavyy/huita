using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectHotline.Pages
{
    public class SelectCityPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@name= 'autocomplete-city']")]
        public IWebElement SearchBarForCity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'city-link']/span")]
        public IWebElement SelectCityButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'lightbox-hd']/p[contains(text(),'Зараз вказано')]")]
        public IWebElement SelectCityHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'wrapper active')]")]
        public IWebElement GetListOfCity { get; set; }

        public IWebElement GetOptionFromSelectCityAutocomplete(string cityName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'ui-menu-wrapper active']//li[contains(text(),'{cityName}')]"));
        }
    }
}
