using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public class ComparePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item item-product']//a[@class = 'title-overflow']")]
        public List<IWebElement> ComparedItems { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']/h1")]
        public IWebElement ComparsionHeader { get; set; }

        public IWebElement DeleteItemAddedToComparison(string productName)
        {
            return Driver.FindElement(By.XPath($".//a[@class = 'title-overflow' and contains(text(),'{productName}')]/preceding-sibling::div/i"));
        }
    }
}
