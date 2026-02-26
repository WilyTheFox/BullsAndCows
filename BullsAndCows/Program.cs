using BullsAndCows.ConsoleApp;

namespace BullsAndCows.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            var game = new Game(digits: 4);
            game.Run();
        }
    }
}