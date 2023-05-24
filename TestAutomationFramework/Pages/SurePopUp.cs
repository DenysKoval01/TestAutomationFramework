using OpenQA.Selenium;
using TestAutomationFramework.Context;
using TestAutomationFramework.Framework;

namespace TestAutomationFramework.Pages
{
    public class SurePopUp : PageBase
    {

        public readonly LocatorObject _yesSureDelete = new("//div[@class='orangehrm-modal-footer']/button[2]", LocatorObject.XPATH);

        public SurePopUp(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        public static SurePopUpContext CreateSurePopUpContext()
        {
            return new SurePopUpContext(_iWebDriver);
        }
    }
}
