using NUnit.Framework;
using System;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Hello");
        }
            
        [Test]
        public void Test1()
        {
            Console.WriteLine("Hello,jhjhj");
        }

        [TestCase(2, 3)]
        [TestCase(1, 1)]
        public void EqualComparation(int a, int b)
        {
            Assert.IsTrue(a == b);
        }
        [TestCase(1, "1")]
        public void EqualComparation(int a, string b)
        {
            Assert.IsTrue(a == Int32.Parse(b));
        }
    }
}