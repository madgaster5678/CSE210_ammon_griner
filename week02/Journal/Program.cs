using System;
// to show creativity i added a mood tracker to the program and some more lines to make it seem friendly.
// the mood tracker allows the user to track their mood from day to day to learn
// how it changes depending on what happened during it.
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (choice != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString();
                    Console.WriteLine("What is your mood like today?");
                    string currentMood = Console.ReadLine();
                    Entry currentEntry = new Entry(date, prompt, response, currentMood);
                    journal.AddEntry(currentEntry);
                    break;
                case 2:
                    journal.JournalDisplay();  
                    break;
                case 3:
                    Console.WriteLine("What is the file name?");
                    string chosenFileName = Console.ReadLine();
                    journal.LoadFile(chosenFileName);
                    break;
                case 4:
                    Console.WriteLine("What is the name of the file?");
                    string fileName = Console.ReadLine();
                    journal.SaveAsFile(fileName);
                    break;
                
            }
            
        }
    }
}