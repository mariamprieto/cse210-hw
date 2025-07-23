using System;


public class Student
{
    private string _name;
    private int _age;

    private int _lessonPerArea;

    private List<ProgressReport> progress = new List<ProgressReport>();

    


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


}