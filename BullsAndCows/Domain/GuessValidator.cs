namespace BullsAndCows.Domain
{
    public static class GuessValidator
    {
        public static GuessValidation ValidateGuess(string guess, int digits)
        {
            bool[] used = new bool[10];

            if (guess.Length != digits)
            {
                return GuessValidation.WrongLength;
            }

            for (int i = 0; i < digits; i++)
            {
                
                char c = guess[i];
                
                if (c < '0' || c > '9')
                {
                    return GuessValidation.NonDigit;
                }
                int d = c - '0';
                if (used[d] == true)
                {
                    return GuessValidation.DuplicateDigit;
                }
                used[d] = true;
            }

            return GuessValidation.Ok;
        }
    }
}