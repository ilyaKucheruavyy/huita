using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace huita.Pages
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = ".//span[@id='logo']")]
        public IWebElement LogoButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='global-enhancements-search-query']")]
        public IWebElement SearchingField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'select-signin')]")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(@class,'reduced-margin-xs')]")]
        public IWebElement GoToFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[contains(@aria-label,'Корзина')]")]
        public IWebElement GoToCartButton { get; set; }
    }
}
