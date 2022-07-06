using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace TestProjectEtsy.Pages
{
    public class PersonalListPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'viewbox-striped border-t']//p/a")]
        public List<IWebElement> ProductAddedToPersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-9 cell-md']/h1")]
        public IWebElement PersonalListHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item-wishlist']")]
        public IWebElement GoToMyListsButton { get; set; }
    }
}
