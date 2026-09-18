using System;

class Program
{
    static void Main(string[] args)
    {
        // to show creativity in this assignment i added a difficulty option to allow the user to choose how many words to hide.
        // i did this because it will allow the user to slowly improve their mastery of the scripture. 
        Console.Clear();

        int difficulty = 0;
        Console.WriteLine("Please choose a difficulty:");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Normal");
        Console.WriteLine("3. Hard");
        int userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            difficulty = 1;
        }
        else if (userChoice == 2)
        {
            difficulty = 3;
        }
        else if (userChoice == 3)
        {
            difficulty = 5;
        }
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("To Continue the memorizer press Enter, otherwise type 'quit'.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }
            scripture.HideRandomWords(difficulty);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

        }
    }
}