using System;


public class Student
{
    private string _name;
    private int _age;

    private int _lessonPerArea;

    private List<ProgressReport> progress = new List<ProgressReport>();

    Dictionary<string, int> AreaLessonProgress = new Dictionary<string, int>();


    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;

    }
    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {
        _age = age;

    }

    public int GetLesson()
    {
        return _lessonPerArea;
    }

    public void SetLesson(int lessonPerArea)
    {
        _lessonPerArea = lessonPerArea;

    }

    public Student(string name, int age, int lessonPerArea)
    {
        _name = name;
        _age = age;
        _lessonPerArea = lessonPerArea;
    }


    public void Register()
    {

        Console.WriteLine("Please, tell us your name:");
        _name = Console.ReadLine();

        Console.WriteLine("Please,give us your age:");
        _age = int.Parse(Console.ReadLine());

        Console.WriteLine("From 1 to 5, how many lessons would you like to take per area?");
        _lessonPerArea = int.Parse(Console.ReadLine());

    }

    public void ChooseArea()
    {

    }

    public int GetNextLesson(string areaName)
    {

        int _lessonsTaken = 0;

        if (AreaLessonProgress.ContainsKey(areaName))
        {
            _lessonsTaken = AreaLessonProgress[areaName];
        }
        if (_lessonsTaken < _lessonPerArea)
        {
            _lessonsTaken++;
            AreaLessonProgress[areaName] = _lessonsTaken;
            return _lessonsTaken;

        }
        else
        {
            Console.WriteLine("You have completed all lessons for this area!");
            return _lessonsTaken;
        }

    }

    public void SaveProgress()
    {

    }

    public void LoadProgress()
    {

    }

    public void DisplaySummaryReport()
    {

    }

}