using huita.Base;
using huita.RuntimeVariables;
using TechTalk.SpecFlow;

namespace huita.Helper
{
    public class BeforeAfterAction : BaseTest
    {
        private readonly WebDriverRuntime _runtimeDriver;

        public BeforeAfterAction(WebDriverRuntime runtimeDriver)
        {
            _runtimeDriver = runtimeDriver;
        }

        [BeforeScenario]
        public void OnStartUp()
        {
            var driverInstance = CreateBrowserDriver();
            _runtimeDriver.Driver = driverInstance;
        }

        [AfterScenario(Order = 0)]
        public void QuitDriver()
        {
            _runtimeDriver.Driver.Quit();   
        }
    }
}