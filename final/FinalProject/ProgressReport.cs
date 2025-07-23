using System;

public class ProgressReport
{

    private string _areaName;
    private List<int> _completedLessons;
    private Dictionary<string, int> _activityTimes;
    private Dictionary<string, int> _grammarAttempts;

    public ProgressReport(string areaName, List<int> completeLessons, Dictionary<string, int> activityTimes, Dictionary<string, int> grammarAttempts)
    {
        _areaName = areaName;
        _completedLessons = completeLessons;
        _activityTimes = activityTimes;
        _grammarAttempts = grammarAttempts;

    }

    public string GetAreaName()
    {
        return _areaName;

    }

    public List<int> GetCompletedLessons()
    {
        return _completedLessons;
    }

    public void AddLessonResult(Lesson lesson)
    {
        int lessonNumber = lesson.GetNumber();
        if (!_completedLessons.Contains(lessonNumber))
        {
            _completedLessons.Add(lessonNumber);
        }

        foreach (Activity activity in lesson.GetActivities())
        {
            string activityName = activity.GetName();
            int time = activity.GetActualTime();

            if (_activityTimes.ContainsKey(activityName))
            {
                _activityTimes[activityName] += time;

            }
            else
            {
                _activityTimes[activityName] = time;
            }
        }

        foreach (var sentence in lesson.GetGrammarSentences())
        {
            string key = sentence.Key;
            int attempts = 1;
            if (_grammarAttempts.ContainsKey(key))
            {
                _grammarAttempts[key] += attempts;
            }
            else
            {
                _grammarAttempts[key] = attempts;
            }
        }
    }

    public void ShowReport()
    {
        Console.WriteLine($"\nProgress Report for Area: {_areaName}");
        Console.WriteLine("Completed Lessons:");
        foreach (int lesson in _completedLessons)
        {
            Console.WriteLine($"\nLesson: {lesson}");

        }

        Console.WriteLine("Activity Times:");
        foreach (var entry in _activityTimes)
        {
            Console.WriteLine($"-{entry.Key}: {entry.Value}  min");

        }

        Console.WriteLine("Grammar Attempts:");
        foreach (var entry in _grammarAttempts)
        {
            Console.WriteLine($"-{entry.Key}: {entry.Value} attempts");

        }
    }

    public int GetNextLessonNuber(int maxLessons)

    {
        int completed = _completedLessons.Count;
        if (completed < maxLessons)
        {
            return completed + 1;

        }
        else
        {
            Console.WriteLine("You have completed all lessons for this areas!");
            return -1;
        }
    }
    public void SaveToFile(string filename = "your_progress.txt")
    {
        using (StreamWriter writer = new StreamWriter(filename, false))
        {
            writer.WriteLine($"Area: {_areaName}");
            foreach (int lesson in _completedLessons)
            {
                writer.WriteLine($"Lesson: {lesson}");

            }

            foreach (var activity in _activityTimes)
            {
                writer.WriteLine($"Activity: {activity.Key} Time: {activity.Value}");

            }

            foreach (var grammar in _grammarAttempts)
            {
                writer.WriteLine($"Grammar: {grammar.Key} Attempts: {grammar.Value}");

            }

            writer.WriteLine();
        }

        Console.WriteLine("Progress report saved successfully.");
    }
    public static void DisplaySimpleSummary(List<ProgressReport> reports, int lessonsPerArea)
    {
        Console.WriteLine("\n===== Simple Progress Summary =====");

        foreach (ProgressReport report in reports)
        {
            string area = report.GetAreaName();
            int completed = report.GetCompletedLessons().Count;

            Console.WriteLine($"\n Area: {area}");
            Console.WriteLine($"Lessons completed: {completed} de {lessonsPerArea}");
            Console.WriteLine($"Status: {(completed == lessonsPerArea ? "Completed" : "In progreso")}");
        }

        Console.WriteLine("===================================");
    }

}