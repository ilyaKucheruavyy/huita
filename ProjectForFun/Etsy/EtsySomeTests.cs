using OpenQA.Selenium;
using huita.Helper;
using huita.Etsy;
using System.Threading;

namespace huita.Etsy
{
    class EtsySomeTests : EtsyMainPage
    {

        public EtsySomeTests(IWebDriver driver) : base(driver) { }

        private By SearchingField = By.Id("global-enhancements-search-query"); 
        private By MoveToCategory = By.Id("desktop-category-nav");
        private By ClickToFilmsMenu = By.Id("catnav-l4-11081");

        private By SortedByButton = By.CssSelector(".wt-menu__trigger.wt-btn");
        private By SortedBy = By.CssSelector(".wt-menu__item");
        private By ClickToFilters = By.CssSelector(".filter-expander");

        private string ClickToFreeShipping = (".//input[@id=\"special-offers-free-shipping\"]");

        #region
        private By ClickToShippingSale = By.Id("special-offers-on-sale");
        private By ClickToProccesingDays = By.Id("max-processing-days-1");

        private By HuitaEbanaya = By.XPath("//div[@data-overlay-for-filters]");
        private By EbanyyOverlay = By.Id("search-filters-overlay");
        private By Huita = By.CssSelector("#search-filter-form");

        public void GoToFilmsMenu()
        {
            driver.WaitElement(10);
            Utilits.MoveToElement(driver, MoveToCategory);
            driver.FindElement(ClickToFilmsMenu).Click();
        }

        public void SearchingSomeProduct()
        {
            
            driver.WaitElement(SearchingField, 10);
            Utilits.MoveToElementAndClick(driver, SearchingField);
            driver.InputSomeText(SearchingField, ProductsName.Rocky);



            //Utilits.SwitchToNewWindow(driver);
            //driver.FindElement(AddToCartButton).Click();
        }

        public void SortedSomeProduct()
        {
            driver.FindElement(SortedByButton).Click();
           // driver.ScrollDown(0, 200);
            Utilits.SortedBySomeWorld(driver, SortedBy, NameSorted.ByHighiestPrice);
            Thread.Sleep(1000);
        }
        #endregion
        public void ChooseFilters()
        {
            driver.WaitElement(ClickToFilters, 10); 
            driver.FindElement(ClickToFilters).Click();

            Utilits.WhenUserSelectCheckbox(driver, ClickToFreeShipping);


            //driver.FindElement(ClickToFreeShipping).Click();    
           // driver.FindElement(ClickToShippingSale).Click();
           // driver.FindElement(ClickToProccesingDays).Click();  



        }
    }
}
