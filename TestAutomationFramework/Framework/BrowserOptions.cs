using OpenQA.Selenium.Chrome;

namespace TestAutomationFramework.Framework
{
    public class BrowserOptions
    {
        public ChromeDriverService ChromeDriverService
        {
            get
            {
                ChromeDriverService chromeDriverService =
                    ChromeDriverService.CreateDefaultService(@".");
                return chromeDriverService;
                ;
            }
        }

        public ChromeOptions ChromeOptions
        {
            get
            {
                ChromeOptions chromeOptions = new()
                {
                    AcceptInsecureCertificates = true
                };
                return chromeOptions;
            }
        }
    }
}
