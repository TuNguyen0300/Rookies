using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CoreFramework.DriverCore;
using CoreFramework.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace CoreFramework.NUnitTestSetup
{
    [TestFixture]
    public class NUnitTestSetup
    {
        public IWebDriver? _driver;
        public WebDriverAction driverBaseAction;

        protected ExtentReports? _extentReport;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            HtmlReport.createReport();
        }

        [SetUp]
        public void SetUp()
        {
            WebDriverManager_.InitDriver("chrome", 1920, 1080);
            _driver = WebDriverManager_.GetCurrentDriver();
            
            driverBaseAction = new WebDriverAction(_driver, _extentTestCase);
        }

        [TearDown]
        public void TearDown()
        {
            //_driver?.Quit();
            TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            if (testStatus.Equals(TestStatus.Passed))
            {
                _extentTestCase?.Pass($"[Pased] Test {TestContext.CurrentContext.Test.Name}");
            }
            else if (testStatus.Equals(TestStatus.Failed))
            {
                _extentTestCase?.Pass($"[Pased] Test {TestContext.CurrentContext.Test.Name} because the error \n");
            }
            _extentReport.Flush();
        }
    }
}
