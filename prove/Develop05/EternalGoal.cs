using System;

public class EternalGoal : Goal
{
    

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override int RecordEvent ()
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
            return $"[ ]{GetName()}";
        }
        
    }

    public override string GetFile()
    {
         return $"Eternal Goal:{GetName()}, {GetDescription()}, {GetPoints()}";
    }

}

