Menu();

void AdditionGame()
{
    Console.WriteLine("You chose A");
}

void SubtractionGame()
{
    Console.WriteLine("You chose S");
}

void MultiplicationGame()
{
    Console.WriteLine("You chose M");
}

void DivisionGame()
{
    Console.WriteLine("You chose D");
}

void QuitGame()
{
    Console.WriteLine("You chose Q");
}

void Menu()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    var date = DateTime.UtcNow;

    Console.WriteLine("-------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division 
Q - Quit the progress");
    Console.WriteLine("-------------------------------------------");

    var gameSelected = Console.ReadLine();


    switch (gameSelected.ToUpper().Trim())
    {
        case "A":
            AdditionGame();
            break;
        case "S":
            SubtractionGame();
            break;
        case "M":
            MultiplicationGame();
            break;
        case "D":
            DivisionGame();
            break;
        case "Q":
            QuitGame();
            break;
        default:
            Console.WriteLine("Please enter in a valid letter");
            break;
    }
}