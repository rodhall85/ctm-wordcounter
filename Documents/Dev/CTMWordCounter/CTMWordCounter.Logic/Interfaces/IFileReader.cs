namespace RodHall.CTMWordCounter.Logic {

    public interface IFileReader {
        string Content { get; }

        void Read(string filePath);
    }
}
