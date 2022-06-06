using huita.Extensions;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace huita.Components
{
    public class OfferedProductOnHomePageSectionComponents
    {
        private readonly WebDriver _driver;

        public OfferedProductOnHomePageSectionComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public List<IWebElement> OfferedProductInSection(string sectionName)
        {
           return _driver.FindElements
                (By.XPath($".//div[contains(@data-appears-component-name,'{sectionName.DeleteSpace()}')]//div[@class = 'wt-block-grid__item ']"))
                .ToList();
        }
    }
}
