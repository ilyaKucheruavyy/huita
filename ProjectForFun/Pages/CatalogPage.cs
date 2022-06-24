using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class CatalogPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@data-search = 'catalog']")]
        public IWebElement SearchBarForCatalog { get; set; }
    }
}
