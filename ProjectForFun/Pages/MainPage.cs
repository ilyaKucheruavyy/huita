using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class MainPage
    {
        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//input[@id = 'doSearch']")]
        public IWebElement SubmitSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//button[@id = 'clearInput']")]
        public IWebElement ClearSerchBarButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class = 'icon-menu icon-menu-catalog']")]
        public IWebElement AllCategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'header-logo']")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@data-carousel= 'visited-carousel']//span[@class = 'title']")]
        public IWebElement ListOfViewedProduct { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'city-link']/span")]
        public IWebElement ChangeCityButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'lightbox-hd']/p[contains(text(),'Зараз вказано')]")]
        public IWebElement ChangeCityHeader { get; set; }
    }
}
