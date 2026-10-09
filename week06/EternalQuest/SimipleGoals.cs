using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted = false;

    public SimpleGoal(bool isCompleted, string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetDetailsString()
    {
        if (_isCompleted)
        {
            return $"[x] {GetName()} ({GetPoints()})";
        }
        else
        {
            return $"[ ] {GetName()} ({GetPoints()})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{_isCompleted}";
    }
}