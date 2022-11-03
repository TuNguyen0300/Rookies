using AutoTest.PageObject;
using NUnit.Framework;
using NUnit.Framework.Internal;
using CoreFrame.NUnitTestSetup;
using AutoTest.TestSetup;

namespace AutoTest
{   
    [TestFixture]
    public class SimpleTest : ProjectNUnitTestSetup
    {

        [Test]
        public void UserCanSearchVideos()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.InputSearchBox("ABC")
                .ClickSearchButton()
                .OpenVideo("Hello");
        }
    }
}