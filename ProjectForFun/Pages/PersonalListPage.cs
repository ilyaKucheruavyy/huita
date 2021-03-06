using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public class PersonalListPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'viewbox-striped border-t']//p/a")]
        public List<IWebElement> ProductAddedToPersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-9 cell-md']/h1")]
        public IWebElement PersonalListHeader { get; set; }

        public IWebElement DeleteItemAddedToPersonalList(string productName)
        {
            return Driver.FindElement(By.XPath($".//p[@class = 'h4']/a[contains(text(),'{productName}')]/../../../../i"));
        }
    }
}
