using System;


/// <summary>
/// Represents the progress report for a specific study area,
/// including completed lessons, activity times, and grammar attempts.
/// </summary>
public class ProgressReport
{


    private string _areaName;
    private List<int> _completedLessons;
    private Dictionary<string, int> _activityTimes;
    private Dictionary<string, int> _grammarAttempts;

    // Constructor to initialize the report with initial data
    public ProgressReport(string areaName, List<int> completeLessons, Dictionary<string, int> activityTimes, Dictionary<string, int> grammarAttempts)
    {
        _areaName = areaName;
        _completedLessons = completeLessons;
        _activityTimes = activityTimes;
        _grammarAttempts = grammarAttempts;

    }
    // Returns the name of the area
    public string GetAreaName()
    {
        return _areaName;

    }
    // Returns the list of completed lessons 
    public List<int> GetCompletedLessons()
    {
        return _completedLessons;
    }
    // Adds the results of a completed lesson to the report
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
    // Displays a detailed report for the specific area
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
    // Returns the next lesson number to be completed or -1 if all lessons are done
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
     // Saves the progress report to a file (overwrite mode)
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
     // Displays a simple summary for all areas with student info
    public static void DisplaySimpleSummary(List<ProgressReport> reports, int lessonsPerArea, List<AreaStudy> allAreas, string studentName, int studentAge)
    {
        Console.WriteLine("\n===== Simple Progress Summary =====");
        Console.WriteLine($"Student: {studentName}, Age: {studentAge}");

        foreach (AreaStudy area in allAreas)
        {
            string areaName = area.GetAreaName();
            ProgressReport report = null;

            foreach (ProgressReport r in reports)
            {
                if (r.GetAreaName() == areaName)
                {
                    report = r;
                    break;
                }
            }

            int completed = report != null ? report.GetCompletedLessons().Count : 0;
            string status = (completed == 0) ? "Not started" : (completed == lessonsPerArea ? "Completed" : "In progreso");

            Console.WriteLine($"\n Area: {areaName}");
            Console.WriteLine($"Lessons completed: {completed} de {lessonsPerArea}");
            Console.WriteLine($"Status: {status}");
        }

        Console.WriteLine("===================================");
    }


}