using CoreFrame.DriverCore;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFrame.NUnitTestSetup
{
    [TestFixture]
    public class NUnitTestSetup
    {
        public IWebDriver? _driver;
        [SetUp]
        public void SetUp()
        {
            WebDriverManager.InitDriver("Chrome", 1920, 1080);
            _driver = WebDriverManager .GetCurrentDriver();
        }
        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
            TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            if (testStatus.Equals(TestStatus.Passed))
            {
                TestContext.WriteLine("Passed");
            } else if (testStatus.Equals(TestStatus.Failed))
            {
                TestContext.WriteLine("Failed");
            }
        }
    }
}
