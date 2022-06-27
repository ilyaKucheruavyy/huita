using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class MainPage
    {
        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//input[@id = 'searchbox']")]
        public IWebElement SearchBar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//input[@id = 'doSearch']")]
        public IWebElement SubmitSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//button[@id = 'clearInput']")]
        public IWebElement ClearSerchBarButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//i[@class = 'icon-menu icon-menu-catalog']")]
        public IWebElement AllCatalogs { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'header-logo']")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@data-carousel= 'visited-carousel']//span[@class = 'title']")]
        public IWebElement ListOfViewedProduct { get; set; }
    }
}
