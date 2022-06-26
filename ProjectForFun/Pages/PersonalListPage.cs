using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public class PersonalListPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'viewbox-striped border-t']//p/a")]
        public List<IWebElement> ProductAddedToPersonalList { get; set; }
    }
}
