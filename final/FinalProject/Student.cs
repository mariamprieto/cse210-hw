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
        while (!int.TryParse(Console.ReadLine(), out _lessonPerArea) || _lessonPerArea < 1 || _lessonPerArea > 5){
            Console.WriteLine("Please enter a valid number between 1 and 5:");
        }
        

    }

    public void ChooseArea(List<AreaStudy> areas)
    {
         Console.WriteLine("\nPlease choose an area to study:");

    for (int i = 0; i < areas.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {areas[i].GetAreaName()} - {areas[i].GetDescription()}");
    }

    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    AreaStudy selectedArea = areas[choice - 1];

    Console.WriteLine($"\nYou selected: {selectedArea.GetAreaName()}");
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
        using (StreamWriter writer = new StreamWriter("progress.txt"))
        {
            foreach (var entry in AreaLessonProgress)
            {
                writer.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
        Console.WriteLine("Progress saved successfuly");
    }

    public void LoadProgress()
    {
        if (!File.Exists("progress.txt"))
        {
            Console.WriteLine("No saved progress found");
            return;

        }

        AreaLessonProgress.Clear();

        string[] lines = File.ReadAllLines("progress.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string area = parts[0];
            int lessons = int.Parse(parts[1]);
            AreaLessonProgress[area] = lessons;
            }
        Console.WriteLine("Pogress loaded succesfully");
    }

    public void DisplaySummaryReport()
    {
        Console.WriteLine($"\nStudent:{_name}, Age:{_age}");
        Console.WriteLine("Lesson progress by area: ");

        foreach (var area in AreaLessonProgress)
        {
            Console.WriteLine($" -{area.Key}:{area.Value}/{_lessonPerArea} lessons completed");

            if (area.Value == _lessonPerArea)
            {
                Console.WriteLine("Completed!");
            }
            else
            {
                Console.WriteLine("In progress");
            }

            }

    }

}