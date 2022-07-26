using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;
using TestProjectHotline.Extensions;

namespace TestProjectHotline.Pages
{
    public  class SearchResultPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'search__title']")]
        public IWebElement SearchResultTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[contains(@class,'catalog-title')]")]
        public IWebElement CategoryTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'search-sidebar-checklist__collapse link']")]
        public IWebElement ShowAllManufacturer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'tabs-item flex center-xs middle-xs active']")]
        public IWebElement AllFilters { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'tabs-item flex center-xs middle-xs']")]
        public IWebElement SelectedFilters { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@class = 'page page--next']")]
        public IWebElement NextPageArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'search-sidebar-filter search-sidebar__item')]")]
        public IWebElement ManufacturerSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'selected__title')]")]
        public IWebElement SelectedFiltersTitle { get; set; }

        public void GetManufacturerFromSearchResultPage(string manufacturerName)
        {
            Driver.UserClicks(
                $".//div[contains(text(),'{manufacturerName}')]/preceding-sibling::input");
        }

        public IList<string> GetListOfTheFoundProduct()
        {
            List<string> ListOfTheFoundProduct = new List<string>();

            var listProduct =  Driver.FindElements(By.XPath(".//a[contains(@class,'list-item__title')]")).ToList();
            foreach (var product in listProduct )
            {
                ListOfTheFoundProduct.Add(product.Text);
            }

            return ListOfTheFoundProduct;
        }

        public IWebElement GоToProductFromSearchResultPage(string productName)
        {
            return Driver.FindElement(By.XPath
                ($".//div[contains(@class, 'list-item__info')]//a[contains(text(),'{productName}')]"));
        }

        public IWebElement GetSortedByOption(string optionName)
        {
            return Driver.FindElement(By.XPath($".//option[contains(text(),'{optionName}')]"));
        }

        public IWebElement GetSelectedFilters(string filterName)
        {
            return Driver.FindElement(
                By.XPath($".//div[contains(@class,'selected__filter')]//span[contains(text(),'{filterName}')]"));
        }
    }
}
