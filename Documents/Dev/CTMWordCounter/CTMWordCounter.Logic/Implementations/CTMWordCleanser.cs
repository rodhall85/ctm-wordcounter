namespace RodHall.CTMWordCounter.Logic {
    using System.Collections.Generic;
    using System.Globalization;

    public class CTMWordCleanser : IWordCleanser {

        private string cleansedWord = string.Empty;

        // This is bad practice. It is better to be explicit about what to allow that what to disallow.
        private readonly List<string> badStrings = new List<string>() { ".", ",", "#", "\"", "*", "?", "!", ":", ";" };

        public string CleansedWord {
            get {
                return this.cleansedWord;
            }
        }

        public void Cleanse(string word) {
            this.cleansedWord = word.Trim();
            this.cleansedWord = cleansedWord.ToLower(CultureInfo.CurrentUICulture);
            badStrings.ForEach(bc => cleansedWord = cleansedWord.Replace(bc, string.Empty));
        }
    }
}
