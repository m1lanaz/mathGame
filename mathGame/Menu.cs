
namespace mathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();

        internal void ShowMenu()
        {
            Console.WriteLine("Please type your name");

            var name = Console.ReadLine();
            var date = DateTime.UtcNow;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division 
Q - Quit the progress");
                Console.WriteLine("-------------------------------------------");

                var gameSelected = Console.ReadLine();


                switch (gameSelected.ToUpper().Trim())
                {
                    case "V":
                        Helpers.GetGames();
                        break;
                    case "A":
                        gameEngine.AdditionGame();
                        break;
                    case "S":
                        gameEngine.SubtractionGame();
                        break;
                    case "M":
                        gameEngine.MultiplicationGame();
                        break;
                    case "D":
                        gameEngine.DivisionGame();
                        break;
                    case "Q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid letter");
                        break;
                }
            } while (isGameOn);
        }
    }
}
