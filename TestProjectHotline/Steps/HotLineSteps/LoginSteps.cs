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
            var logInPage = _driver.GetPage<LoginPage>();
            _driver.WaitForElementToBeDisplayed(logInPage.LoginButton);
            logInPage.LoginButton.Click();
            _driver.WaitForElementToBeDisplayed(logInPage.LoginTitle);
            logInPage.EmailField.SendKeys(email);
            logInPage.PasswordField.SendKeys(password);
            logInPage.SubmitButton.Click();
        }

        [Then(@"User sees '(.*)' nickname instead of 'login' button")]
        public void ThenUserSeesNicknameInsteadOfLoginButton(string userNickname)
        {
            var logInPage = _driver.GetPage<LoginPage>();
            var mainPage = _driver.GetPage<MainPage>();
            _driver.WaitForElementToBeDisplayed(mainPage.HotlineLogo);
            Assert.AreEqual(userNickname, logInPage.NickName.Text, 
                $"Actual result '{logInPage.NickName.Text}' not equals to expected result '{userNickname}'");
        }
    }
}
