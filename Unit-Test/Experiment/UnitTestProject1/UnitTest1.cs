using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsStringMyNameNick()
        {
            // ARRANGE
            var checker = new Experiment.Welcome();
            // ACT

            var result = checker.welcome1("Nick", "Nick");

            // ASSERT
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void AreTwoStringsDifferent()
        {
            // ARRANGE
            var checker = new Experiment.Welcome();
            // ACT

            var result = checker.welcome1("Nickwan", "");

            // ASSERT
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsStringEmptyOrNull()
        {
            // ARRANGE
            var checker = new Experiment.Welcome();
            // ACT

            var result = checker.welcome1(string.Empty, string.Empty);

            // ASSERT
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void IsThisNumberPrime()
        {
            // arrange
            var checker = new Experiment.PrimeNumber();

            // act

            var result = checker.isPrime(11, 0);

            // assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsNumberGreaterThanZero()
        {
            // arrange
            var checker = new Experiment.PrimeNumber();

            // act
            var result = checker.isPrime(11, 0);

            //assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsInputLessThanZero()
        {
            // arrange
            var checker = new Experiment.PrimeNumber();

            // act
            var result = checker.isPrime(-2, 0);

            // assert
            Assert.AreEqual(false, result);
        }

    }
}
