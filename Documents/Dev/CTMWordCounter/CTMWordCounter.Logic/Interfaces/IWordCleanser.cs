namespace RodHall.CTMWordCounter.Logic {

    public interface IWordCleanser {
        string CleansedWord { get; }
        void Cleanse(string word);
    }
}