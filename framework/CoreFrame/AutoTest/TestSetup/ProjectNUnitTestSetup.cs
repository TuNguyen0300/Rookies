using CoreFramework.NUnitTestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.TestSetup
{
    public class ProjectNUnitTestSetup : NUnitTestSetup
    {
        [SetUp]
        public void Setup()
        {
            _driver.Url = "http://demo.guru99.com";
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}
