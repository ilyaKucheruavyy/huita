using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace TestProjectEtsy
{
    [Binding]
    public class EtsySteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public EtsySteps(WebDriver driver)
        {
            _driver = driver;
        }
    }
}
