namespace RodHall.CTMWordCounter.Tests {
    using Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class CTMWordCleanserTests {

        [TestMethod]
        public void CTMWordCleanswer_Init_ReturnsInstance() {
            CTMWordCleanser sut = new CTMWordCleanser();

            Assert.IsInstanceOfType(sut, typeof(CTMWordCleanser));
            Assert.IsTrue(sut.CleansedWord == string.Empty);
        }

        [TestMethod]
        public void Cleanse_GivenBadStrings_BadStringsRemoved() {
            CTMWordCleanser sut = new CTMWordCleanser();
            string word = "hello!\"?;";
            string expected = "hello";

            sut.Cleanse(word);
            string actual = sut.CleansedWord;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Cleanse_GivenCleanWord_ReturnsSameWord() {
            CTMWordCleanser sut = new CTMWordCleanser();
            string word = "hello";
            string expected = word;

            sut.Cleanse(word);
            string actual = sut.CleansedWord;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Cleanse_GivenWordWithCaps_ReturnsLowerCase() {
            CTMWordCleanser sut = new CTMWordCleanser();
            string word = "Hello";
            string expected = "hello";

            sut.Cleanse(word);
            string actual = sut.CleansedWord;

            Assert.AreEqual(expected, actual);
        }
    }
}
