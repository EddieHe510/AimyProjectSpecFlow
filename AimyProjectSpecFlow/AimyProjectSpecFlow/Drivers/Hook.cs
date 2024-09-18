using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace AimyOneLoginTest.Drivers
{
    [TestFixture]
    public class Hook
    {
        public static IWebDriver driver;
        protected Browser browser;

        [BeforeScenario]
        public void StartWebsite()
        {
            Reporter.ReportingCreateTest(TestContext.CurrentContext.Test.MethodName);

            string testBrowser = GetBrowserFromConfig();
            switch (testBrowser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://uat2-app.aimyone.com");

            browser = new Browser(driver);
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            DriverEndTest();
            Reporter.ReportingEndRepoting();
            driver.Quit();
        }

        private string GetBrowserFromConfig()
        {
            return "chrome";
        }

        private void DriverEndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    Reporter.ReportingLogFail($"Test has failed {message}");
                    break;

                case TestStatus.Skipped:
                    Reporter.ReportingLogInfo($"Test skipped {message}");
                    break;

                default:
                    break;
            }

            Reporter.ReportingLogScreenShot("Ending test", browser.BroswerGetScreenShot());
        }
    }
}
