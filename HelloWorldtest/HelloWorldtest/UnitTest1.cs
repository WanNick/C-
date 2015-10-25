using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloWorldTester()
        {
            // ARRANGE
            var checker = new helloWorld1.helloWorldTester();
            // ACT
            var result = checker.helloWorld("Hello World", "Hello World");

            // ASSERT
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestIfStringIsDifferent()
        {
            // ACT
            var check = new helloWorld1.helloWorldTester();

            // ARRANGE

            var result = check.helloWorld("Hello World", "");

            // ASSERT
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestIfStringIsEmpty()
        {
            // ARRANGE
            var check = new helloWorld1.helloWorldTester();

            //ACT
            var result = check.helloWorld(string.Empty, string.Empty);
            //ASSERT

            Assert.AreEqual(true, result);
           
        }
        [TestMethod]
        public void TestIfStringContainsUpperCaseH()
        {
            // ARRANGE
            var check = new helloWorld1.helloWorldTester();

            // ACT
            var result = check.helloWorld("Hello World", "");

            // ASSERT
            Assert.AreEqual(true, result);
        }
    }
}
