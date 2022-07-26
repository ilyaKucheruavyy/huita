using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectHotline.Pages
{
    public class CategoryPage: BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'viewbox']/p")]
        public IWebElement CategoryHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@role = 'textbox']")]
        public IWebElement SerchBarForCategory { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'wrapper active')]")]
        public IWebElement GetListOfCategory { get; set; }

        public IWebElement GetOptionFromCategoryAutocomplete(string categoryName)
        {
            return Driver.FindElement(By.XPath($".//div[@class = 'ui-menu-wrapper active']//div[contains(text(),'{categoryName}')]"));
        }

        public IWebElement GetCategoryFromSearchResultPage(string categoryName)
        {
            return Driver.FindElement(
                By.XPath($".//div[@class = 'search-sidebar__item content']//b[contains(text(), '{categoryName}')]"));
        }

        public IWebElement GetSubCategoryFromSearchResultPage(string subCategoryName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[contains(@class, 'catalogs__name') and contains(text(), '{subCategoryName}')]"));
        }
    }
}
