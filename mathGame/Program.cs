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
    Console.WriteLine("IT WORKED!");
}
else if (gameSelected.ToUpper().Trim() == "S")
{
    Console.WriteLine("You chose S");
}
else if (gameSelected.ToUpper().Trim() == "M")
{
    Console.WriteLine("You chose M");
}
else if (gameSelected.ToUpper().Trim() == "D")
{
    Console.WriteLine("You chose D");
}
else if (gameSelected.ToUpper().Trim() == "Q")
{
    Console.WriteLine("You chose Q");
}
else
{
    Console.WriteLine("Please enter in a valid letter");
};