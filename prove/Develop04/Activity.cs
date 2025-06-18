using System;

public class Activity
{
    //Declare Tthe attributes are defined globally within the class to allow access and reuse across different activity classes 
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = " ";
        _description = " ";
        _duration = 0;

    }

    public void SetActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()


    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}\n{_description}\n");

    }

    public void DisplayEndingMessage()


    {
        Console.Write($"\nWell done!\nThanks for your time, You finished  the {_name} for {_duration} seconds");

    }

    public void PauseWithSpinner(int seconds)
    {
        string[] _spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(_spinner[i % 4]);
            Thread.Sleep(500);

            Console.Write("\b");
            Console.Write("\b");
            

            
        }
            Console.Write(" ");
            Console.Write("\b");
        
    }
    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds;i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1500);

            Console.Write("\b \b");
        }

        
    }


}