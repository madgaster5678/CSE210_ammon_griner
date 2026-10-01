using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private List<string> _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("Read the prompt given and try to list as many responses as you can for the duration you choose");
        _count = new List<string>();
        _prompts = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        DisplayPrompt();
        ShowCountDown(4);
        while (DateTime.Compare(DateTime.Now, endTime) < 0)
        {
            GetListFromUser(endTime);
        }
        Console.WriteLine($"you wrote down {_count.Count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser(DateTime endTime)
    {
        string accum = "";
        while (DateTime.Compare(DateTime.Now, endTime) < 0)
        {
            string input = Console.ReadKey().KeyChar.ToString();
        
            if (input == "\r")
            {
                Console.WriteLine("");
                _count.Add(accum);
                accum = "";
            }
            else
            {
                accum += input;
            }
        }
        return _count;
    }

}