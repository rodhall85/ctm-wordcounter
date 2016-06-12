namespace RodHall.CTMWordCounter.App {
    using Data;
    using Logic;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class WordCounter : Form {
        private IFileReader fileReader = null;
        private IWordCleanser wordCleanser = null;

        public readonly IDictionary<string, Word> WordFrequency = new Dictionary<string, Word>();

        public WordCounter(IFileReader fileReader, IWordCleanser wordCleanser) {
            if (fileReader == null) {
                throw new ArgumentNullException("fileReader");
            }
            if (wordCleanser == null) {
                throw new ArgumentNullException("wordCleanser");
            }

            InitializeComponent();

            this.fileReader = fileReader;
            this.wordCleanser = wordCleanser;
        }

        public void Process(string filePath) {
            this.fileReader.Read(filePath);
            IList<string> words = this.fileReader.Content.Split(' ').ToList();
            words.ToList().ForEach(w => AddToDictionary(w));
        }

        private void AddToDictionary(string word) {
            this.wordCleanser.Cleanse(word);
            string cleansedWord = this.wordCleanser.CleansedWord;

            if (!string.IsNullOrEmpty(cleansedWord)) {
                if (this.WordFrequency.ContainsKey(cleansedWord)) {
                    this.WordFrequency[cleansedWord].Frequency++;
                }
                else {
                    this.WordFrequency.Add(cleansedWord, new Word(new PrimeNumberEvaluator()) { Frequency = 1 });
                }
            }
        }

        private void btnCountWords_Click(object sender, EventArgs e) {
            // Would make this configurable or prompt user for path
            this.Process("Stories/The Railway Children [E Nesbit].txt");

            this.lblTotal.Text = "Total Unique Words: " + this.WordFrequency.Count;

            this.dgvWords.AutoGenerateColumns = true;
            var bindlingList = this.WordFrequency
                .OrderByDescending(w => w.Value.Frequency)
                .Select(w => new {
                    Word = w.Key,
                    Frequency = w.Value.Frequency,
                    IsPrime = w.Value.IsPrime
                })
                .ToList();

            this.dgvWords.DataSource = bindlingList;
            this.dgvWords.Visible = true;
            this.dgvWords.Refresh();
        }

    }
}
