using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        string name = "Breathing Activity";
        string description="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        SetActivity(name, description);

        
    }

    public void DoBreathingActivity()
    {
        DisplayStartingMessage();

        Console.Write("How long, in seconds would you like for your session?:");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        Console.Write("Get ready...");
        Console.WriteLine();
        PauseWithSpinner(5);
        Console.WriteLine();

        int interval = 6;
        int seconds = GetDuration();
        int cycles = seconds / interval;
        for (int i = 0; i < cycles; i++)
        {

            
            Console.WriteLine();
            Console.Write("Breathe in ...");
            PauseWithCountdown(3);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            PauseWithCountdown(3);
            Console.WriteLine();
             
        }
        DisplayEndingMessage();
    }




}