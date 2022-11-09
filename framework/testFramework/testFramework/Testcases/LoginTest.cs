using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class LoginTest : ProjectNUnitTestSetup
    {
        [Test]
        public void Id1_Login()
        {
            LoginPage loginPage = new LoginPage(_driver, _extentTestCase);
            loginPage.inputUserName("test");
        }
    }
}
