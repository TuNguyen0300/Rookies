using CoreFrame.NUnitTestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.TestSetup
{
    internal class ProjectNUnitTestSetup : NUnitTestSetup
    {
        [SetUp]
        public void Setup()
        {
            _driver.Url = "http://google.com";
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}
