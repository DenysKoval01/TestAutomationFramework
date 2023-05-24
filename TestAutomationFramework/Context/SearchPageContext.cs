using OpenQA.Selenium;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Context
{
    public class SearchPageContext
    {

        private readonly SearchPage _searchPage;

        public SearchPageContext(IWebDriver webDriver)
        {
            _searchPage = new SearchPage(webDriver);
        }

        public SearchPageContext ClickOnAdminTab()
        {
            _searchPage.SeleniumActions.Click(_searchPage._admin);
            return this;
        }

    }
}
