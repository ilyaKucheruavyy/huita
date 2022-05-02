using BoDi;
using huita.Base;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace huita.Helper
{
    [Binding]
    public class BeforeAfterAction : BaseTest
    {
        private readonly IObjectContainer _container;

        public BeforeAfterAction(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void OnStartUp()
        {
            var driverInstance = CreateBrowserDriver();
            _container.RegisterInstanceAs(driverInstance);
        }

        [AfterScenario(Order = 100000)]
        public void QuitDriver()
        {
            var driver = _container.Resolve<WebDriver>();
            driver.Close();
            driver.Dispose();
        }
    }
}