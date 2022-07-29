using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestProjectHotline.Extensions;

namespace TestProjectHotline.Pages
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//input[@id = 'doSearch']")]
        public IWebElement SubmitSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@id = 'search-form-main']//button[@id = 'clearInput']")]
        public IWebElement ClearSerchBarButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//li[contains(@class, 'catalog')]/a")]
        public IWebElement AllCategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'header-logo']")]
        public IWebElement HotlineLogo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id= 'searchbox']")]
        public IWebElement SearchBar { get; set; }

        public void MoveToAllCategories()
        {
            Driver.ScrollToElementWithJS(".menu-main-item.catalog");
        }

        public void ClickOnAllCategory()
        {
            Driver.UserClicksWhithJS(".//li[contains(@class, 'catalog')]/a");
        }
    }
}
