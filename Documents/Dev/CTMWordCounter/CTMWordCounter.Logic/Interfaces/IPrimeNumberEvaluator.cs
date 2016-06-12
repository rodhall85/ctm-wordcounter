namespace RodHall.CTMWordCounter.Logic {

    public interface IPrimeNumberEvaluator {
        bool IsPrime(uint number);
        bool IsPrime(ulong number);
    }
}
