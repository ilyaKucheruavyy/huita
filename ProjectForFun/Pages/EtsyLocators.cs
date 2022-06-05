using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace huita.Etsy
{
    public class EtsyLocators
    {
        [FindsBy(How=How.Id,Using = "global-enhancements-search-query")]
        public IWebElement SearchingField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".wt-menu__trigger.wt-btn")]
        public IWebElement SortedByButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".wt-menu__item")]
        public List<IWebElement> SortedBy { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".filter-expander")]
        public IWebElement ClickToFilters { get; set; }

        #region StringForFilters
        public string ClickToFreeShipping { get; } = (".//input[@id=\"special-offers-free-shipping\"]");
        public string ClickToShippingSale { get; } = ("//input[@id = \"special-offers-on-sale\"]");
        public string TypeOfProduct { get; } = ("//input[@id = \"item-type-input-1\"]");
        public string SubmitButton { get; } = ("//button[@class = \"wt-btn wt-btn--primary wt-width-full wt-mt-xs-3 wt-mb-xs-3 wt-mr-xs-3\"]");
        #endregion

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'wt-grid wt-grid--block wt-pl-xs-0 tab-reorder-container']/li[1]")]
        public IWebElement SelectFirstProduct { get; set; }

        [FindsBy(How = How.Id,Using = "inventory-variation-select-0")]
        public IWebElement ChooseProductSize { get; set; }
        public string ProductSizeValue { get; } = "1790407768";

        [FindsBy(How = How.Id,Using = "inventory-variation-select-1")]
        public IWebElement ChooseProductOption { get; set; }
        public string ProductOptionValue { get; } = "1807140853";

        [FindsBy(How = How.CssSelector,Using = ".wt-btn--filled.wt-width-full")]
        public IWebElement AddToCartButton { get; set; }
    }
}
