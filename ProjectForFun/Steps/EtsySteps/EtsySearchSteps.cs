using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace TestProjectEtsy.Steps.EtsySteps
{
    [Binding]
    public class EtsySearchSteps: SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsySearchSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User search product '(.*)'")]
        public void WhenUserSearchSomeProduct(string productName)
        {
        }
    }
}
