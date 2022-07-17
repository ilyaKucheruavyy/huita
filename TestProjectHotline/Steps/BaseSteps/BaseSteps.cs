using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using System.Threading;
using TestProjectHotline.Providers;

namespace TestProjectHotline.Steps.BaseSteps
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
        public void GivenUserGoTo(string environment)
        { 
            switch(environment)
            {
                case "HotLineEnv":
                    _driver.Navigate().GoToUrl("https://hotline.ua/");
                    break;
                default:
                    throw new Exception($"{environment} is not exist");
            }
        }

        [When(@"User waits '(.*)' second")]
        public void WhenUserWaitsSecond(int second)
        {
            Thread.Sleep(second*1000);
        }
    }
}
