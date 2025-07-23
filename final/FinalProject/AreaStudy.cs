using System;

/// <summary>
/// Represents a specific study area (e.g., Business, Travel, Health),
/// containing its name, description, and a list of lessons.
/// </summary>
public class AreaStudy
{

    private string _areaName;// Name of the study area

    private string _description; // Description of what this area focuses on

    private List<Lesson> lessons = new List<Lesson>();// List of lessons included in this area

    // Getter and Setter 
    public string GetAreaName()
    {
        return _areaName;
    }

    public void SetAreaName(string areaName)
    {
        _areaName = areaName;

    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;

    }

    /// <summary>
    /// Constructor to initialize the study area with a name and description.
    /// </summary>
    public AreaStudy(string areaName, string description)
    {
        _areaName = areaName;
        _description = description;

    }

    /// <summary>
    /// Displays all the lessons assigned to this area in the console.
    /// </summary>
    public virtual void ShowLessons()
    {
        foreach (Lesson lesson in lessons)
        {
            Console.WriteLine($"Lesson: {lesson.GetNumber()} - {lesson.GetTitle} - {lesson.GetDescription()}");
        }

    }

    /// <summary>
    /// Returns the list of lessons. Can be overridden in derived classes.
    /// </summary>
    public virtual List<Lesson> GetLessons()
    {
        return lessons;
    }

}