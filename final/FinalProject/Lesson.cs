using System;
using System.Diagnostics;

/// <summary>
/// Represents a single English lesson that includes reading, grammar, and pronunciation activities.
/// Tracks completion status, user interaction, and lesson metadata.
/// </summary>
public class Lesson
{
    // Private attributes 
    private int _number;
    private string _title;
    private string _description;
    private string _readingText;
    private List<string> _pronunciationWords;
    private Dictionary<string, string> _grammarSentences;
    private List<Activity> _activities;
    private bool _isComplete;


    // Public getters for accessing lesson information
    public int GetNumber()
    {
        return _number;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetReadingText()
    {
        return _readingText;
    }
    public List<string> GetPronunciationWords()
    {
        return _pronunciationWords;

    }
    public Dictionary<string, string> GetGrammarSentences()
    {
        return _grammarSentences;

    }

    public List<Activity> GetActivities()
    {
        return _activities;

    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    /// <summary>
    /// Constructor for initializing a lesson with all attributes.
    /// </summary>
    public Lesson(int number, string title, string description, string readingText, List<string> pronunciationWords, Dictionary<string, string> grammarSentences)
    {
        _number = number;
        _title = title;
        _description = description;
        _readingText = readingText;
        _pronunciationWords = pronunciationWords;
        _grammarSentences = grammarSentences;
        _activities = new List<Activity>();
        _isComplete = false;

        _activities.Add(new ReadingActivity());
        _activities.Add(new GrammarActivity());
        _activities.Add(new PronunciationActivity());

    }

    /// <summary>
    /// Displays the lesson title, description, and available activities with their status.
    /// </summary>
    public void ShowMenuActivities()
    {
        Console.WriteLine($"Lesson {_number}:{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("Avaliable Activities: ");

        foreach (Activity activity in _activities)
        {
            Console.WriteLine($"- {activity.GetName()} {activity.GetStatus()}");
        }

    }

    /// <summary>
    /// Handles the logic to start and complete a selected activity by name.
    /// Prevents repeating already completed activities.
    /// </summary>
    public void CompleteActivity(string activityName)
    {
        foreach (Activity activity in _activities)
        {
            if (activity.GetName().ToLower() == activityName.ToLower())
            {
                if (activity.GetStatus().ToLower() == "completed")
                {
                    Console.WriteLine($"The activity \"{activity.GetName()}\" has already been completed.");
                    return;
                }

                activity.Start(this);
                return;
            }
        }
        Console.WriteLine("Activity not found.");
    }


    /// <summary>
    /// Displays a full report of the lesson including time spent and status of each activity.
    /// </summary>

    public void GenerateLessonReport()
    {
        Console.WriteLine($"Lesson Report: {_number} : {_title}");
        foreach (Activity activity in _activities)
        {

            Console.WriteLine($" {activity.GetName()} - Time: {activity.GetActualTime()} min - Status{activity.GetStatus()} ");

        }

        Console.WriteLine($"Completed: {_isComplete}");
    }

    /// <summary>
    /// Checks if all activities in the lesson have been marked as completed.
    /// </summary>

    public bool IsFullyCompleted()
    {
        foreach (Activity activity in _activities)
        {
            if (activity.GetStatus().ToLower() != "completed")
            {
                return false;
            }
        }
        return true;
    }
    /// <summary>
    /// Marks the lesson as fully completed (to be called after verifying all activities are done).
    /// </summary>
    public void MarkAsCompleted()
    {
        _isComplete = true;
    }



}