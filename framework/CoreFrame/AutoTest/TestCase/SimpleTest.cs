using NUnit.Framework.Internal;
using AutoTest.TestSetup;
using AutoTest.PageObject;

namespace Testcases
{
    [TestFixture]
    public class SimpleTests : ProjectNUnitTestSetup
    {
        [Test]
        public void USerCanSearchVideos()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.inputUserName("test");
        }
    }
}