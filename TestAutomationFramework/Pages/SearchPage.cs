using OpenQA.Selenium;
using TestAutomationFramework.Context;
using TestAutomationFramework.Framework;

namespace TestAutomationFramework.Pages
{
    public class SearchPage : PageBase
    {
        public readonly LocatorObject _admin = new(".//ul[@class='oxd-main-menu']/li[@class='oxd-main-menu-item-wrapper'][1]//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name']", LocatorObject.XPATH);

        public SearchPage(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        public static SearchPageContext CreateSearchPageContext()
        {
            return new SearchPageContext(_iWebDriver);
        }
    }
}
