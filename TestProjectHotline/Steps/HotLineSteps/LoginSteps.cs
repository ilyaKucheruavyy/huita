using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestProjectHotline.Extensions;
using NUnit.Framework;
using TestProjectHotline.Pages;

namespace TestProjectHotline.Steps.EtsySteps
{
    [Binding]
    public class LoginSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public LoginSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User login with '(.*)' email and '(.*)' password")]
        public void WhenUserLoginWithEmailAndPassword(string email, string password)
        {
            var logInPage = new LoginPage();
            var mainPage = new MainPage();
            _driver.WaitForElementToBeDisplayed(logInPage.LoginButton);

            _driver.UserClicks(".//div[@class = 'item-login']/a");
            _driver.WaitForElementToBeDisplayed(logInPage.EmailField);
            logInPage.EmailField.SendKeys(email);
            logInPage.PasswordField.SendKeys(password);
            logInPage.SubmitButton.Click();
        }

        [Then(@"User sees '(.*)' nickname instead of 'login' button")]
        public void ThenUserSeesNicknameInsteadOfLoginButton(string userNickname)
        {
            var logInPage = new LoginPage();
            var mainPage = new MainPage();
            _driver.WaitForElementToBeDisplayed(mainPage.HotlineLogo);
            Assert.AreEqual(logInPage.NickName.Text, userNickname, 
                $"Actual result '{logInPage.NickName.Text}' not equals to expected result '{userNickname}'");
        }
    }
}
