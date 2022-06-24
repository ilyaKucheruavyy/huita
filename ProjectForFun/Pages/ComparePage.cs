using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public class ComparePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item item-product']//a[@class = 'title-overflow' and contains(text(),'')]")]
        public List<IWebElement> ProductAddedToCompare { get; set; }

    }
}
