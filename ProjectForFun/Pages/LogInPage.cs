using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public  class LogInPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item-login']")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']//input[@type = 'text']")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']//input[@type = 'password']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']//input[@type = 'submit']")]
        public IWebElement SubmitButton { get; set; }    
    }
}
