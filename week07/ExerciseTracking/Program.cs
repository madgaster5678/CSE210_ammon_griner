using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2026, 10, 13), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2026, 10, 14), 30, 10.0));
        activities.Add(new Swimming(new DateTime(2026, 10, 16), 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}