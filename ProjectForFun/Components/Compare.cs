using OpenQA.Selenium;

namespace TestProjectEtsy.Components
{
    public class Compare : BaseComponent
    {
        public IWebElement GetCompareCheckboxForItem(string productName)
        {
            return Driver.FindElement
                (By.XPath
                ($".//div[@class = 'list-body']//div[@class = 'list-item__title-container m_b-5']" +
                $"//a[contains(text(),'{productName}')]" +
                $"//parent::div//parent::div//preceding-sibling::div//input"));
        }
    }
}
