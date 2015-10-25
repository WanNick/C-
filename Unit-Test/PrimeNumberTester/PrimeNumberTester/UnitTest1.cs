using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsThisNumberPrime()
        {
            //ARRANGE
            var checker = new ConsoleApplication1.PrimeNumber();

            // ACT
            var result = checker.isPrime(17, 17);
            // Change the first number within the bracket to check to see if it's a Prime. i.e change the number (##, 17).

            //ASSERT

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsNumberLessThanZero()
        {
            // ARRANGE

            var checker = new ConsoleApplication1.PrimeNumber();

            // ACT
            var result = checker.isPrime(-3, -3);
            //Change the first value i.e (-3, 0); Change the first (-3) to test if number is greater than zero.

            // ASSERT
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void IsNumberGreaterThanZero()
        {
            // ARRANGE

            var checker = new ConsoleApplication1.PrimeNumber();

            // ACT
            var result = checker.isPrime(68, 0);
            //Change the first value i.e (1, 0); Change the one to test if number is greater than zero.

            // ASSERT
            Assert.AreEqual(false, result);
        }
    }
}
