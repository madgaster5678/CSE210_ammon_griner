using System;

class Program
{
    static void Main(string[] args)
    {
        // I have added a tracker for the activities to show creativity.
        // I have added this is because I like to have numbers to track when it comes to the things i do.
        string choice = "0";
        int breatheCount = 0;
        int reflectCount = 0;
        int listingCount = 0;
        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Focus Activity Tracker.");
            Console.WriteLine("Here are the activities you can choose from:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View activity log");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breatheCount += 1;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                reflectCount += 1;
            }
            else if (choice == "3")
            {
                ListingActivity listen = new ListingActivity();
                listen.Run();
                listingCount += 1;
            }
            else if (choice == "4")
            {
                Console.WriteLine("These are the activities you have done:");
                Console.WriteLine($"Breathing Activity: {breatheCount}");
                Console.WriteLine($"Reflection Activity: {reflectCount}");
                Console.WriteLine($"Listing Activity: {listingCount}");
            }
        }
        Console.WriteLine("Thanks for using the Activity Tracker");
        Console.WriteLine("Goodbye");
    }
}