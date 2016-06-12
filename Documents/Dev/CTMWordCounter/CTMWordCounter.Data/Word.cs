namespace RodHall.CTMWordCounter.Data {
    using RodHall.CTMWordCounter.Entities;
    using RodHall.CTMWordCounter.Logic;
    using System;

    public class Word : UniqueWord {
        private IPrimeNumberEvaluator primeNumberEvaluator = null;

        public Word(IPrimeNumberEvaluator primeNumberEvaluator) {
            if (primeNumberEvaluator == null) {
                throw new ArgumentNullException("primeNumberEvaluator");
            }

            this.primeNumberEvaluator = primeNumberEvaluator;
        }

        public override bool IsPrime {
            get {
                return this.primeNumberEvaluator.IsPrime(this.Frequency);
            }
        }
    }
}
