using System;

// SimpleGoal: a goal that can be completed only once
public class SimpleGoal : Goal

{
    // Attribute that indicates if the goal has been completed
    private bool _isCompleted;

    // Constructor that inherits attributes from the base class and adds its own specific attributes
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    // Override methods from the base class:
    // Mark when the goal is completed, check if it is complete, display its status, and store these records
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
        return $"Simple Goal: {GetName()}, {GetDescription()}, {GetPoints()}, {GetIsDeleted()}, {GetDeleteReason()}, {_isCompleted}";
    }
}



