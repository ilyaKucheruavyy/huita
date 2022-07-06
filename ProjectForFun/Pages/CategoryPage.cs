using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class CategoryPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'viewbox']/p")]
        public IWebElement CategoryHeader { get; set; }
    }
}
