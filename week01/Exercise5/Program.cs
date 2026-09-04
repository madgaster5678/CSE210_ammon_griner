using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResults(userName, squaredNumber);

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to my program");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter what you favorite number is: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquaredNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResults(string name, int squared)
        {
            Console.WriteLine($"{name}, your number squared is {squared}");
        }
    }
}