namespace BullsAndCows.Domain
    public readonly struct GuessResult
    {
        public int Bulls { get; }
        public int Cows { get; }

        public GuessResult(int bulls, int cows)
        {
            Bulls = bulls;
            Cows = cows;
        }
    }
}