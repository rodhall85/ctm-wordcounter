namespace RodHall.CTMWordCounter.Logic {
    using System;

    public class PrimeNumberEvaluator : IPrimeNumberEvaluator {
        public bool IsPrime(uint number) {
            if (number < 2) {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) {
                    return false;
                }
            }

            return true;
        }

        public bool IsPrime(ulong number) {
            throw new NotImplementedException();
        }
    }
}
