using System;

public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _currentCount;

    private int _bonusPoints;


    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;

    }
    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonuspoints) : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonuspoints;
    }
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

