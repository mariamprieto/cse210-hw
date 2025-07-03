using System;


public class Goal
{

    private string _name;

    private string _description;
    private int _points;

    private bool _isDeleted = false;
    private string _deleteReason = " ";

    


    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;

    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription (string description)
    {
        _description = description;

    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints (int points)
    {
        _points = points;

    }

    public bool GetIsDeleted()
    {
        return _isDeleted;
    }

    public string GetDeleteReason()
    {
        return _deleteReason;
    }

    public void SetIsDeleted(string deleteReason)
    {
        _isDeleted = true;
        _deleteReason = deleteReason;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;


    }
    


    public virtual int RecordEvent()
    {
        return _points;
    }
    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetStatus()
    {
        if (_isDeleted)
        {
            return $"([Goal Deleted] {_name} (Reason: {_deleteReason}))";
        }
        else
        {
            return $"([ ] {_name} ({_description}) )";
        }
    }

    public virtual string GetFile()
    {
        return $"{_name}, {_description}, {_points}";
    }

}