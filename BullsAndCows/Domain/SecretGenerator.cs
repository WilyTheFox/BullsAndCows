namespace BullsAndCows.Domain
{
    public static class SecretGenerator
    {
        public static string GenerateSecret(int digits)
        {
            if (digits < 1 || digits > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(digits));
            }

            string secret = string.Empty;

            int[] digitsPool = new int[10];

            for (int i = 0; i < 10; i++)
            {
                digitsPool[i] = i;
            }

            Random rng = new Random();

            for (int i = digitsPool.Length - 1; i > 0; i--)
            {
                int j = rng.Next(0, i + 1);
                int temp = digitsPool[i];
                digitsPool[i] = digitsPool[j];
                digitsPool[j] = temp;
            }

            for (int k = 0; k < digits; k++)
            {
                char c = (char)('0' + digitsPool[k]);
                secret += c;
            }

            return secret;
        }
    }
}
