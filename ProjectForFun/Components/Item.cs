using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public  class Item : BaseComponent
    {
        public IWebElement GetToProductOnSearchResultPage(string productName)
        {
            return Driver.FindElement(By.XPath
                ($".//div[@class = 'list-body']//div[@class = 'list-item__title-container m_b-5']//a[contains(text(),'{productName}')]"));
        }
        public IWebElement DeleteItemAddedToComparison(string productName)
        {
            return Driver.FindElement(By.XPath($".//a[@class = 'title-overflow' and contains(text(),'{productName}')]/preceding-sibling::div/i"));
        }

        public IWebElement DeleteItemAddedToPersonalList(string productName)
        {
            return Driver.FindElement(By.XPath($".//p[@class = 'h4']/a[contains(text(),'{productName}')]/../../../../i"));
        }
    }
}
