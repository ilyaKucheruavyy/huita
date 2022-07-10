using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class CategoryPage: BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'viewbox']/p")]
        public IWebElement CategoryHeader { get; set; }

        public IWebElement GetOptionFromCategoryPage(string categoryName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'ui-menu-wrapper']//div[contains(text(),'{categoryName}')]"));
        }

        public IWebElement GetCategoryFromSearchResultPage(string categoryName)
        {
            return Driver.FindElement(
                By.XPath($".//div[@class = 'search-sidebar__item content']//b[contains(text(), '{categoryName}')]"));
        }

        public IWebElement GetSubCategoryFromSearchResultPage(string subCategoryName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[@class = 'search-sidebar__item content']//div[@class = 'search-sidebar-catalogs__name link link--black' and contains(text(), '{subCategoryName}')]"));
        }
    }
}
