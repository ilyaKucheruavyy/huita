using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class CatalogComponent
    {
        private readonly WebDriver _driver;

        public CatalogComponent (WebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UserChooseCatalogOnSearchResultPage(string categoryName)
        {
            return _driver.FindElement
                (By.XPath($".//div[@class = 'search-sidebar__item content']//b[contains(text(), '{categoryName}')]"));
        }
        public IWebElement UserCgooseSubCatalogOnSearchResultPage(string subCategoryName)
        {
            return _driver.FindElement
                (By.XPath
                ($".//div[@class = 'search-sidebar__item content']//div[@class = 'search-sidebar-catalogs__name link link--black' and contains(text(), '{subCategoryName}')]"));
        }
    }
}
