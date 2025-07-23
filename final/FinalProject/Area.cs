using System;


public class AreaStudy
{

    private string _areaName;

    private string _description;

    private List<Lesson> lessons = new List<Lesson>();


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

    public AreaStudy(string areaName, string description)
    {
        _areaName = areaName;
        _description = description;

    }

    public virtual void ShowLessons()
    {
        foreach (Lesson i in lessons)
        {
            Console.WriteLine("Numero de Leccion + Titulo de Leccion + Descripcion");
        }

    }

    public virtual List<Lesson> GetLessons()
    {
        return lessons;
    }

}