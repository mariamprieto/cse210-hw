using System;

// EternalGoal: a goal that never gets marked as complete, can be recorded unlimited times
public class EternalGoal : Goal
{
    // Constructor that inherits attributes from the base class and adds its own specific attributes

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // Override methods from the base class:
    // Mark when the goal is completed, check if it is complete, display its status, and store these records
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStatus()
    {
        if (GetIsDeleted())
        {
            return $"([Goal Deleted] {GetName()} (Reason: {GetDeleteReason()}))";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()})";
        }

    }

    public override string GetFile()
    {
        return $"Eternal Goal:{GetName()}, {GetDescription()}, {GetPoints()}, {GetIsDeleted()}, {GetDeleteReason()}";
    }

}

