using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public class ComparePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item-compare']")]
        public IWebElement GoToComparisonButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item item-product']//a[@class = 'title-overflow']")]
        public List<IWebElement> ComparedItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']/h1")]
        public IWebElement ComparsionHeader { get; set; }
    }
}
