using System;

public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _currentCount;

    private int _bonusPoints;

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
        return $"[{(IsComplete()? "X":" ")}]{GetName()}--Completed {_currentCount}/{_requiredCount}";
    }

    public override string GetFile()
    {
         return $"Checklist Goal:{GetName()}, {GetDescription()}, {GetPoints()},{_bonusPoints},{_requiredCount},{_currentCount}";
    }

}

