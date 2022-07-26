using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectHotline.Pages
{
    public class PersonalListPage : BasePage
    {
        //[FindsBy(How = How.XPath, Using = ".//div[contains(@class,'viewbox')]//p/a")]
        //public IList<IWebElement> ProductAddedToPersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-9 cell-md']/h1")]
        public IWebElement PersonalListHeader { get; set; }

        public IWebElement DeleteItemAddedToPersonalList(string productName)
        {
            return Driver.FindElement(By.XPath($".//p[@class = 'h4']/a[contains(text(),'{productName}')]/../../../../i"));
        }

        public IWebElement ProductAddedToPersonalLIst(string pn)
        {
            return Driver.FindElement(By.XPath($".//div[contains(@class,'viewbox')]//p/a[contains(text(),'{pn}')]"));
        }
    }
}
