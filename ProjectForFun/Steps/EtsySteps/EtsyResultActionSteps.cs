using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace TestProjectEtsy.Steps.EtsySteps
{
    [Binding]
    public class EtsyResultActionSteps: SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsyResultActionSteps(WebDriver driver)
        {
            _driver = driver;
        }
    }
}
