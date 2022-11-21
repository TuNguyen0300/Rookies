using NUnit.Framework;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class TestScenario3 : ProjectNUnitTestSetup
    {
        [Test]
        public void TestAuto() 
        {
            EditPage editPage = new EditPage(_driver);
            editPage.SelectElement();
            editPage.CheckDisplayElement();
            editPage.SelectWebTable();
            editPage.CheckDisplayWebTable();
            editPage.GoToEditScreen();

        }

    }
}
