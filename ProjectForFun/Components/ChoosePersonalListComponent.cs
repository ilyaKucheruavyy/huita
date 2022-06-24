
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProjectEtsy.Components
{
    public class ChoosePersonalListComponent
    {
        private readonly WebDriver _driver;

        public ChoosePersonalListComponent(WebDriver driver)
        {
            _driver = driver;
        }

        public void UserChoosePersonalList(string listName)
        {
            var SelectObject = new SelectElement(_driver.FindElement(By.XPath(".//select[@class = 'select-arrow']")));
            SelectObject.SelectByText(listName);
        }
    }
}
