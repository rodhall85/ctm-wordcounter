namespace RodHall.CTMWordCounter.Logic {
    using System;
    using System.IO;

    public class TextFileStreamReader : IFileReader {

        private string content = string.Empty;

        public string Content {
            get {
                return content;
            }
        }

        public void Read(string filePath) {
            if (string.IsNullOrEmpty(filePath)) {
                throw new ArgumentNullException("filePath");
            }

            using (StreamReader reader = File.OpenText(filePath)) {
                this.content = reader.ReadToEnd();
            }
        }
    }
}
