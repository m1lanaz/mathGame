using static System.Formats.Asn1.AsnWriter;

Menu();

void AdditionGame()
{

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {

        Console.Clear();
        Console.WriteLine("Thank you for picking the diviion game!");

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        //int.parse converts the string input into an integer
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!  Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect!  Type any key for the next question");
            Console.ReadLine();
        }
    }
    Console.WriteLine($"The game is over! Your score is {score}");
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

    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine("Thank you for picking the diviion game!");

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect! Type any key for the next question");
            Console.ReadLine();
        }
    }
    Console.WriteLine($"The game is over! Your score is {score}");
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

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;


    return result;
}