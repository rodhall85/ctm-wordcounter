namespace CTMWordCounter.Tests {
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RodHall.CTMWordCounter.Logic;
    [TestClass]
    public class PrimeNumberEvaluatorTests {
        [TestMethod]
        public void IsPrime_Given1_ReturnsFalse() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = false;

            bool actual = sut.IsPrime(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Given2_ReturnsTrue() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = true;

            bool actual = sut.IsPrime(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Given3_ReturnsTrue() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = true;

            bool actual = sut.IsPrime(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Given4_ReturnsFalse() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = false;

            bool actual = sut.IsPrime(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Given4021_ReturnsTrue() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = true;

            bool actual = sut.IsPrime(4021);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Given1043_ReturnsFalse() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = false;

            bool actual = sut.IsPrime(1043);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_GivenEven_ReturnsFalse() {
            IPrimeNumberEvaluator sut = new PrimeNumberEvaluator();
            bool expected = false;

            bool actual = sut.IsPrime(4022);

            Assert.AreEqual(expected, actual);
        }
    }
}
