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

if (gameSelected.ToUpper().Trim() == "A")
{
    AdditionGame();
}
else if (gameSelected.ToUpper().Trim() == "S")
{
    SubtractionGame();
}
else if (gameSelected.ToUpper().Trim() == "M")
{
    MultiplicationGame();
}
else if (gameSelected.ToUpper().Trim() == "D")
{
    DivisionGame();
}
else if (gameSelected.ToUpper().Trim() == "Q")
{
    QuitGame();
}
else
{
    Console.WriteLine("Please enter in a valid letter");
};

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