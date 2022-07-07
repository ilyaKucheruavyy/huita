using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Category : BaseComponent
    {
        public IWebElement GetCategoryOnSearchresultPage(string categoryName)
        {
            return Driver.FindElement
                (By.XPath($".//div[@class = 'search-sidebar__item content']//b[contains(text(), '{categoryName}')]"));
        }

        public IWebElement GetSubCategoryOnSearchresultPage(string subCategoryName)
        {
            return Driver.FindElement
                (By.XPath
                ($".//div[@class = 'search-sidebar__item content']" +
                $"//div[@class = 'search-sidebar-catalogs__name link link--black' and contains(text(), '{subCategoryName}')]"));
        }
    }
}
