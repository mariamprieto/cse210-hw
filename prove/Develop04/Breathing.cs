using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        string name = "Breathing Activity";
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        SetActivity(name, description);

        Console.Write("How long, in seconds would you likefor your session?:");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DoBreathingActivity()
    {
        DisplayStartingMessage();
        int interval = 0;
        int cycles = _duration / interval;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Get ready...");
            Console.WriteLine();
            Console.Write("Breathe in ...");
            PauseWithCountdown(3);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            Console.Write("Breathe in ...");
            PauseWithCountdown(3);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            Console.Write("Breathe in ...");
            PauseWithCountdown(3);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }




}