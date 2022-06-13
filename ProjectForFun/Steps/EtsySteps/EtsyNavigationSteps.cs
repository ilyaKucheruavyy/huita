using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestProjectEtsy.Helper;
using TestProjectEtsy.Components;

namespace TestProjectEtsy.Steps
{
    [Binding]
    public class EtsyNavigationSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsyNavigationSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User go to '(.*)' menu")]
        public void WhenUserGoToMenu(string tabName)
        {
            var components = new NavigationTabComponents(_driver);

            _driver.MoveToElement(components.NavigationTabs(tabName));
        }

        [When(@"User go to '(.*)' sub menu")]
        public void WhenUSerFoToSubMenu(string subMenuName)
        {
            var components = new NavigationTabComponents(_driver);

            (components.NavigationSubMenu(subMenuName)).Click();
        }
    }
}
