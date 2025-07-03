using System;

// ChecklistGoal: requires being completed multiple times to finish
public class ChecklistGoal : Goal
{
    // Attributes that store how many times the goal needs to be completed, 
    // the current progress, and the bonus points awarded upon full completion
    private int _requiredCount;
    private int _currentCount;

    private int _bonusPoints;


    // Basic getter and setter methods to access or update the current completion count
    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;

    }

    // Constructor that inherits attributes from the base class and adds its own specific attributes

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonuspoints) : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonuspoints;
    }

    // Override methods from the base class:
    // Mark when the goal is completed, check if it is complete, display its status, and store these records
    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount >= _requiredCount)
        {
            return GetPoints() + _bonusPoints;
        }
        else
        {
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        return _currentCount >= _requiredCount;
    }

    public override string GetStatus()
    {

        if (GetIsDeleted())
        {
            return $"([Goal Deleted] {GetName()} (Reason: {GetDeleteReason()}))";
        }
        else
        {
            return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()})--Completed {_currentCount}/{_requiredCount}";
        }

    }

    public override string GetFile()
    {
        return $"Checklist Goal:{GetName()}, {GetDescription()}, {GetPoints()}, {GetIsDeleted()}, {GetDeleteReason()}, {_bonusPoints},{_requiredCount},{_currentCount}";
    }

}

