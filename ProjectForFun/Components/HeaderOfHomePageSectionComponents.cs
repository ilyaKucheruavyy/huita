using huita.Extensions;
using OpenQA.Selenium;

namespace huita.Components
{
    public class HeaderOfHomePageSectionComponents
    {
        private readonly WebDriver _driver;

        public HeaderOfHomePageSectionComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public string SectionOfHomePage(string nameOfPageSection)
        {
            return _driver.FindElement
                (By.XPath($".//div[contains(@data-appears-component-name,'{nameOfPageSection.DeleteSpace()}')]//h2")).Text;
        }
    }
}
