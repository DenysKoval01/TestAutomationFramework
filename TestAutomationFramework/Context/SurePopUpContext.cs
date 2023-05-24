using OpenQA.Selenium;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Context
{
    public class SurePopUpContext
    {

        private readonly SurePopUp _surePopUp;

        public SurePopUpContext(IWebDriver webDriver)
        {
            _surePopUp = new SurePopUp(webDriver);
        }

        public SurePopUpContext ClickDeleteButton()
        {
            _surePopUp.SeleniumActions.Click(_surePopUp._yesSureDelete);
            return this;
        }
    }
}
