using OpenQA.Selenium;
using TestAutomationFramework.Context;
using TestAutomationFramework.Framework;

namespace TestAutomationFramework.Pages
{
    public class AdminHeader : PageBase
    {
        public AdminHeader(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        public readonly LocatorObject _userManagement = new(".//span[@class='oxd-topbar-body-nav-tab-item'][contains(text(),'User Management ')]", LocatorObject.XPATH);
        public readonly LocatorObject _job = new(".//span[@class='oxd-topbar-body-nav-tab-item'][contains(text(),'Job')]", LocatorObject.XPATH);
        public readonly LocatorObject _dropDownElements = new("//ul[@class='oxd-dropdown-menu']/li/a[@role='menuitem']", LocatorObject.XPATH);

        public static AdminHeaderContext CreateAdminHeaderContext()
        {
            return new AdminHeaderContext(_iWebDriver);
        }
    }
}
