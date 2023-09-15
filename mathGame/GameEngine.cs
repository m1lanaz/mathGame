
using System;

namespace mathGame
{
    internal class GameEngine
    {
        internal void AdditionGame()
        {

            Console.Clear();
            Console.WriteLine("Thank you for picking the addition game!");

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, "Addition");

            Console.WriteLine($"The game is over! Your score is {score}");
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
        }

        internal void SubtractionGame()
        {
            Console.Clear();
            Console.WriteLine("Thank you for picking the subtraction game!");

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                //int.parse converts the string input into an integer
                if (int.Parse(result) == firstNumber - secondNumber)
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

            Helpers.AddToHistory(score, "Subtraction");

            Console.WriteLine($"The game is over! Your score is {score}");
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
        }

        internal void MultiplicationGame()
        {
            Console.Clear();
            Console.WriteLine("Thank you for picking the multiplication game!");

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                //int.parse converts the string input into an integer
                if (int.Parse(result) == firstNumber * secondNumber)
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

            Helpers.AddToHistory(score, "Multiplication");

            Console.WriteLine($"The game is over! Your score is {score}");
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
        }

        internal void DivisionGame()
        {
            Console.Clear();
            Console.WriteLine("Thank you for picking the diviion game!");
            var score = 0;

            for (int i = 0; i < 5; i++)
            {

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, "Divison");

            Console.WriteLine($"The game is over! Your score is {score}");
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
        }
    }
}
