using System;
/// <summary>
/// Abstract base class representing a generic learning activity.
/// This class is inherited by specific activities like Reading, Grammar, and Pronunciation.
/// </summary>
public abstract class Activity
{

    private string _name; //Name of the activity 
    private int _estimatedTime; // Estimated time to complete the activity (in minutes)
    private int _actualTime; // Actual time taken by the user to complete the activity (in minutes)
    private string _status;// Status of the activity

    // Getter and Setter 
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
    
    /// <summary>
    /// Abstract method that must be implemented by each specific activity type.
    /// Defines how the activity starts and interacts with the lesson.
    /// </summary>
    public abstract void Start(Lesson lesson);

    /// <summary>
    /// Virtual method to show content related to the activity.
    /// Can be overridden by child classes for customized display.
    /// </summary>
    public virtual void ShowContent(Lesson lesson)
    {
        Console.WriteLine($"Starting {_name} the activity");
    }
}