using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("Practice breathing to help your focus, you will set a time and take deep breaths in and out for the duration you set.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            int remainingTime = duration - elapsedTime;
            if ( remainingTime >= 8)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(4);

                Console.WriteLine("Breathe out...");
                ShowCountDown(4);
                elapsedTime += 8;
            }
            else
            {
                int breatheIn = remainingTime / 2;
                int breatheOut = remainingTime - breatheIn;

                Console.WriteLine("Breathe in...");
                ShowCountDown(breatheIn);

                Console.WriteLine("Breathe out...");
                ShowCountDown(breatheOut);

                elapsedTime += (breatheOut + breatheIn);
            }
        }
        DisplayEndingMessage();
    }
}