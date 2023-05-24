using OpenQA.Selenium;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Context
{
    public class AdminHeaderContext
    {
        private readonly AdminHeader _adminHeader;

        public AdminHeaderContext(IWebDriver webDriver)
        {
            _adminHeader = new AdminHeader(webDriver);
        }

        public AdminHeaderContext ClickOnJob()
        {
            _adminHeader.SeleniumActions.Click(_adminHeader._job);
            return this;
        }

        public AdminHeaderContext ClickOnPayGradesElement()
        {

            _adminHeader.SeleniumActions.FindElementInCollection(_adminHeader._dropDownElements, "Pay Grades").Click();
            return this;
        }
    }
}
