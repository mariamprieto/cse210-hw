using System;

public abstract class Activity
{

    private string _name;
    private int _estimatedTime;
    private int _actualTime;
    private string _status;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;


    }
    public int GetEstimatedTime()
    {
        return _estimatedTime;
    }

    public void SetEstimatedTime(int estimatedTime)
    {
        _estimatedTime = estimatedTime;


    }
    public int GetActualTime()
    {
        return _actualTime;
    }

    public void SetActualTime(int actualTime)
    {
        _actualTime = actualTime;


    }

    public string GetStatus()
    {
        return _status;
    }

    public void SetStatus(string status)
    {
        _status = status;

    }

    public abstract void Start(Lesson lesson);

    public virtual void ShowContent(Lesson lesson)
    {
        Console.WriteLine($"Starting {_name} the activity");
    }
}