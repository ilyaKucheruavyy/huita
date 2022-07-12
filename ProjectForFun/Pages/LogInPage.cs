using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectEtsy.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class = 'item-login']//span[@class = 'name ellipsis']")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']//input[@type = 'text']")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']//input[@type = 'password']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'cell-12']//input[@type = 'submit']")]
        public IWebElement SubmitButton { get; set; }
    }
}
