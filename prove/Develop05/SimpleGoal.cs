using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }
    public override int RecordEvent()
    {
        if (!_isCompleted)

        {
            _isCompleted = true;
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStatus()
    {

        if (GetIsDeleted())
        {
            return $"([Goal Deleted] {GetName()} (Reason: {GetDeleteReason()}))";
        }
        else
        {
            return (_isCompleted ? "[X]" : "[ ]") + $" {GetName()} ({GetDescription()})";
        }
        
    }

    public override string GetFile()
    {
        return $"Simple Goal: {GetName()}, {GetDescription()}, {GetPoints()},{_isCompleted}";
    }
}



