using AutoTest.PageObject;
using NUnit.Framework;
using NUnit.Framework.Internal;
using CoreFrame.NUnitTestSetup;
using AutoTest.TestSetup;

namespace AutoTest
{   
    [TestFixture]
    public class SimpleTest : NUnitTestSetup
    {

        [Test]
        public void UserCanSearchVideos()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.inputUserName("test"); 
        }
    }
}