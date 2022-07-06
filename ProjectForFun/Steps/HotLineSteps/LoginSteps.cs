using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestProjectEtsy.Pages;
using TestProjectEtsy.Extensions;
using NUnit.Framework;

namespace TestProjectEtsy.Steps.EtsySteps
{
    [Binding]
    public class LoginSteps : SpecFlowContext
    {
        private readonly WebDriver _driver;

        public LoginSteps(WebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User login with email: '(.*)' and password: '(.*)'")]
        public void WhenUserLoginWithEmailAndPassword(string email, string password)
        {
            var logInPage = new LogInPage();

            logInPage.LoginButton.Click();
            _driver.WaitForElementToBeDisplayed(logInPage.EmailField);

            logInPage.EmailField.SendKeys(email);
            logInPage.PasswordField.SendKeys(password);

            logInPage.SubmitButton.Click();
        }

        [Then(@"User sees nickname '(.*)' instead of 'login' button")]
        public void UserSeesNicknameInsteadOfLoginButton(string userNickname)
        {
            var logInPage = new LogInPage();

            Assert.AreEqual(logInPage.LoginButton.Text, userNickname, 
                $"Actual result {logInPage.LoginButton.Text} is not equal expected result {userNickname}");
        }
    }
}
