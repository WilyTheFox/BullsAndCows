using BullsAndCows.Domain;

namespace BullsAndCows.ConsoleApp
{
    public class RoundController
    { 
        public int Digits { get; }
        public int GuessCount { get; private set; }
        public bool IsWon { get; private set; }
        private readonly string _secret;
        public RoundController(int digits)
        { 
            Digits = digits;
            _secret = SecretGenerator.GenerateSecret(digits);
        }
        public GuessValidation Validate(string guess)
        {
            return GuessValidator.ValidateGuess(guess, Digits);
        }
        public GuessResult SubmitGuess(string guess)
        {
            GuessResult result = GuessEvaluator.EvaluateGuess(_secret, guess);
            GuessCount++;
            if (result.Bulls == Digits)
            { 
                IsWon = true;
            }
            return result;
        }        
    }
}