namespace BullsAndCows.Domain
{
    public static class GuessEvaluator
    {
        public static GuessResult EvaluateGuess(string secret, string guess)
        {
            int bulls = 0;
            int cows = 0;

            int[] secretFreq = new int[10];
            int[] guessFreq = new int[10];

            int totalMatches = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bulls++;
                }
                int sDigit = secret[i] - '0';
                int gDigit = guess[i] - '0';
                secretFreq[sDigit]++;
                guessFreq[gDigit]++;
            }

            for (int d = 0; d < 10; d++)
            {
                totalMatches += Math.Min(secretFreq[d], guessFreq[d]);
            }

            cows = totalMatches - bulls;

            return new GuessResult(bulls, cows);
        }
    }
}