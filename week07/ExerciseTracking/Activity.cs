using System;
using System.Data.Common;

public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public int GetLength()
    {
        return _length;
    }

    public virtual string GetSummary()
    {
        string currentDate = _date.ToString("dd MMM yyyy");
        string activityName = this.GetType().Name;
        string activityLength = _length.ToString();
        string activityDistance = GetDistance().ToString("0.0");
        string activitySpeed = GetSpeed().ToString("0.0");
        string activityPace = GetPace().ToString("0.0");
        return currentDate + " " + activityName + $" ({activityLength} min)- Distance {activityDistance} miles, Speed {activitySpeed} mph, Pace: {activityPace} min per mile";
    }
}