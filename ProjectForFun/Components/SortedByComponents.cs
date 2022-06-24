using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProjectEtsy.Pages;

namespace TestProjectEtsy.Components
{
    public class SortedByComponents
    {
        private readonly WebDriver _driver;

        public SortedByComponents(WebDriver driver)
        {
            _driver = driver;
        }

        public void SortBy(string sortedBy)
        {
            var SelectObject = new SelectElement(_driver.FindElement(By.XPath(".//select[@class = 'select__field']")));
            SelectObject.SelectByText(sortedBy);
        }
    }
}
