namespace RodHall.CTMWordCounter.Tests {
    using Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TextFileStreamReaderTests {

        [TestMethod]
        public void Read_Init_ValidInstance() {
            TextFileStreamReader sut = new TextFileStreamReader();

            Assert.IsInstanceOfType(sut, typeof(TextFileStreamReader));
            Assert.IsInstanceOfType(sut.Content, typeof(string));
        }

        [TestMethod]
        public void Read_Example1_HasContent() {
            TextFileStreamReader sut = new TextFileStreamReader();

            sut.Read("Files/example1.txt");

            Assert.IsFalse(string.IsNullOrEmpty(sut.Content));
        }
    }
}
