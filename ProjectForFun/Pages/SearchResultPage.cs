using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public  class SearchResultPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'search-sidebar-checklist__collapse link']")]
        public IWebElement ShowAllManufacturer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'tabs-item flex center-xs middle-xs active']")]
        public IWebElement AllFilters { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'tabs-item flex center-xs middle-xs']")]
        public IWebElement SelectedFilters { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'list-body']//div[@class = 'list-item__title-container m_b-5']")]
        public List<IWebElement> ProductList { get; set; }
    }
}
