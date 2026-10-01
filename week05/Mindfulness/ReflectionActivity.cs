using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
    {
        SetName("Reflection Activity");
        SetDescription("Reflect on the following prompt and questions for a duration you choose.");
        _prompts = new List<string>();
        _questions = new List<string>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int elapsedTime = 0;

        DisplayPrompt();
        while (elapsedTime < duration)
        {
            int remainingTime = duration - elapsedTime;
            if (remainingTime >= 5)
            {
                DisplayQuestion();
                ShowSpinner(5);
                elapsedTime += 5;
            }
            else
            {
                DisplayQuestion();
                ShowSpinner(remainingTime);
                elapsedTime += remainingTime;
            }
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }


}