using OpenQA.Selenium;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Context
{
    public class LoginPageContext
    {
        private readonly LoginPage _loginPage;

        public LoginPageContext(IWebDriver webDriver)
        {
            _loginPage = new LoginPage(webDriver);
        }

        public LoginPageContext OpenHomePageUrl(string url)
        {
            _loginPage.SeleniumActions.OpenUrl(url);
            return this;
        }

        public LoginPageContext LoginIntoSystem(string userName, string password)
        {
            _loginPage.SeleniumActions.EntTextInTextBox(_loginPage._username, userName)
                .EntTextInTextBox(_loginPage._password, password)
                .Click(_loginPage._login);
            return this;
        }
    }
}
