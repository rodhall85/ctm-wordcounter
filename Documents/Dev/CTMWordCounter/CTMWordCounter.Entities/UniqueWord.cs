namespace RodHall.CTMWordCounter.Entities {
    public abstract class UniqueWord {
        public string Word { get; set; }
        public uint Frequency { get; set; }
        public abstract bool IsPrime { get; }
    }
}
