using System;
using System.Diagnostics;


public class Lesson
{
    private int _number;
    private string _title;
    private string _description;
    private string _readingText;
    private List<string> _pronunciationWords;
    private Dictionary<string, string> _grammarSentences;
    private List<Activity> _activities;
    private bool _isComplete;

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

    public void ShowMenuActivities()
    {
        Console.WriteLine($"Lesson {_number}:{_title}");
        Console.WriteLine("Choose an activity");

    }

    public void CompleteActivity(string activityName)
    {

    }

    public void GenerateLessonReport()
    {

    }

    public void MarkAsCompleted()
    {
        _isComplete = true;
    }

}