using System;
using BullsAndCows.Domain;

namespace BullsAndCows.ConsoleApp
{
    public class Game
    {
        private readonly int _digits;

        public Game (int digits)
        {
            _digits = digits;
        }

        public void Run()
        {
            while (true)
            {
                var round = new RoundController(_digits);
                while (!round.IsWon)
                {
                    Console.Write($"Enter your {_digits}-digit guess (or 'quit'): ");
                    string input = (Console.ReadLine() ?? string.Empty).Trim();

                    if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                    GuessValidation validation = round.Validate(input);
                    if (validation != GuessValidation.Ok)
                    {
                        Console.WriteLine(GetValidationMessage(validation, _digits));
                        continue;
                    }
                    GuessResult result = round.SubmitGuess(input);
                    Console.WriteLine($"{result.Bulls} bulls, {result.Cows} cows");
                }
                Console.WriteLine($"You win in {round.GuessCount} guesses!");
                Console.Write("Play again? (y/n): ");
                string answer = (Console.ReadLine()??string.Empty).Trim();
                if (!answer.Equals("y", StringComparison.OrdinalIgnoreCase))
                { 
                    return ;
                }
            }
        }

        private static string GetValidationMessage(GuessValidation validation, int digits)
        {
            return validation switch
            {
                GuessValidation.WrongLength => $"Wrong length. Please enter exactly {digits} digits.",
                GuessValidation.NonDigit => "Digits only (0-9).",
                GuessValidation.DuplicateDigit => "No duplicate digits allowed.",
                _ => "Invalid guess."
            };
        }
    }
}
