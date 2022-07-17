using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectHotline.Pages
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//iframe[@class = 'grv-iframe']")]
        public IWebElement Iframe { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//input[@id = 'doSearch']")]
        public IWebElement SubmitSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//button[@id = 'clearInput']")]
        public IWebElement ClearSerchBarButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class = 'icon-menu icon-menu-catalog']")]
        public IWebElement AllCategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'header-logo']")]
        public IWebElement HotlineLogo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'city-link']/span")]
        public IWebElement SelectCityButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'lightbox-hd']/p[contains(text(),'Зараз вказано')]")]
        public IWebElement SelectCityHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id= 'searchbox']")]
        public IWebElement SearchBar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name = 'autocomplete-city']")]
        public IWebElement SearchBarForSelectedCity { get; set; }

        public IWebElement GetOptionFromSelectCityWindow(string cityName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'ui-menu-wrapper']//li[contains(text(),'{cityName}')]"));
        }
    }
}
