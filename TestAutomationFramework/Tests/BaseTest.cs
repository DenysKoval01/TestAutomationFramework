using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationFramework.Framework;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Tests
{
    public class BaseTest
    {

        private IWebDriver WebDriver
        {
            get; set;
        }

        protected PageBase Pages
        {
            get; private set;
        }
        private BrowserFactory BrowserFactory
        {
            get; set;
        }

        [SetUp]
        public void BeforeWholeTest()
        {
            BrowserFactory = new BrowserFactory();
            WebDriver = BrowserFactory.InitializeBrowser("chrome");
            Pages = new PageBase(WebDriver);
        }


        [TearDown]
        public void TearDown()
        {
            BrowserFactory.CloseBrowser(WebDriver);
        }
    }
}
