using System;
using System.Threading;

public class Activity
{
    string[] animation = { "|", "/", "-", "\\" };
    private string _name = "";
    private string _description = "";
    private int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"For this activity you will do the following:\n{_description}");
        Console.WriteLine("How long do you want the activity to last?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Starting activity: ");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done");
        ShowSpinner(5);
        Console.WriteLine($"You completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(animation[i % animation.Length]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(seconds - i);
            Thread.Sleep(1000);
        }
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
}