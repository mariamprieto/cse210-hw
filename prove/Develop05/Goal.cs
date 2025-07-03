using System;

// Base class Goal: defines common attributes for all goals
public class Goal
{
    // Attributes to store the goal's name, description, assigned points, 
    // and (if deleted) the reason provided by the user
    private string _name;

    private string _description;
    private int _points;

    private bool _isDeleted = false;
    private string _deleteReason = " ";



    // Basic getter and setter methods
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

    public void SetDescription(string description)
    {
        _description = description;

    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;

    }

    // Method to mark the goal as deleted and set a reason
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

    // Base constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;


    }

    // Virtual methods that will be inherited and customized by child classes;
    // used to update and store progress when recording achieved goals

    public virtual int RecordEvent()
    {
        return _points;
    }
    public virtual bool IsComplete()
    {
        return true;
    }

    // Display goal status (includes deleted state if applicable)
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
    // Save goal information to file
    public virtual string GetFile()
    {
        return $"{_name}, {_description}, {_points}, {_isDeleted}, {_deleteReason}";
    }

}