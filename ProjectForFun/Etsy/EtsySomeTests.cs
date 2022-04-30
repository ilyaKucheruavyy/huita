using OpenQA.Selenium;
using huita.Helper;
using huita.Etsy;
using huita.Base;
using System.Threading;

namespace huita.Etsy
{
    class EtsySomeTests : Driver
    {

        public EtsySomeTests(IWebDriver driver) : base(driver) { }

        #region Elements
        private By SearchingField = By.Id("global-enhancements-search-query"); 
        private By MoveToCategory = By.Id("desktop-category-nav");
        private By ClickToFilmsMenu = By.Id("catnav-l4-11081");

        private By SortedByButton = By.CssSelector(".wt-menu__trigger.wt-btn");
        private By SortedBy = By.CssSelector(".wt-menu__item");
        private By ClickToFilters = By.CssSelector(".filter-expander");
        #endregion

        #region StringForFilters
        private string ClickToFreeShipping = (".//input[@id=\"special-offers-free-shipping\"]");
        private string ClickToShippingSale = ("//input[@id = \"special-offers-on-sale\"]");
        private string TypeOfProduct = ("//input[@id = \"item-type-input-1\"]");
        private string SubmitButton = ("//button[@class = \"wt-btn wt-btn--primary wt-width-full wt-mt-xs-3 wt-mb-xs-3 wt-mr-xs-3\"]");
        #endregion

        private By SelectFirstProduct = By.XPath("//ul[@class = 'wt-grid wt-grid--block wt-pl-xs-0 tab-reorder-container']/li[1]");
        private By ChooseProductSize = By.Id("inventory-variation-select-0");
        private string ProductSizeValue = "1790407768";

        private By ChooseProductOption = By.Id("inventory-variation-select-1");
        private string ProductOptionValue = "1807140853";

        private By AddToCartButton = By.CssSelector(".wt-btn--filled.wt-width-full");

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

        public void ChooseFilters()
        {
            driver.WaitElement(ClickToFilters, 10); 
            driver.FindElement(ClickToFilters).Click();

            Utilits.WhenUserSelectCheckbox(driver, ClickToFreeShipping);
            Utilits.WhenUserSelectCheckbox(driver, ClickToShippingSale);

            Thread.Sleep(1000);
            Utilits.ScrollToElementWithJS(driver, "#item-type-input-1");
            Utilits.WhenUserSelectCheckbox(driver, TypeOfProduct);
            Utilits.WhenUserSelectCheckbox(driver, SubmitButton);
        }

        public void ChooseFirstProduct()
        {
            driver.WaitElement(SelectFirstProduct,10);

            driver.FindElement(SelectFirstProduct).Click();
            Utilits.SwitchToNewWindow(driver);
            driver.ScrollPage(0, 50);    
        }

        public void SelectProduct()
        {
            Utilits.SelectSomeElementByValue(driver, ChooseProductSize, ProductSizeValue);

            driver.WaitElement(ChooseProductOption, 10);
            Utilits.SelectSomeElementByValue(driver,ChooseProductOption, ProductOptionValue);

            driver.WaitElement(AddToCartButton, 10);    
            driver.FindElement(AddToCartButton).Click();
        }
    }
}
