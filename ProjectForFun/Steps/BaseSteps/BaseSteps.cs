using TestProjectEtsy.Providers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;

namespace TestProjectEtsy.Steps.BaseSteps
{
    [Binding]
    public class BaseSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public BaseSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"User go to '(.*)'")]
        public void GivenUserGoToHotline(string environment)
        { 
            switch(environment)
            {
                case "HotLineEnv":
                    _driver.Navigate().GoToUrl(EnvironmentProvider.HotLineEnv);
                    break;
                case "secondEnv":
                    _driver.Navigate().GoToUrl(EnvironmentProvider.SecondEnv);
                        break;
                    default:
                    throw new Exception($"{environment} is not exsist");
            }
        }
    }
}
