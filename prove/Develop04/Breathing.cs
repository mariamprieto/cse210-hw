using System;

public class BreathingActivity : Activity
{
    // Constructor that sets the activity's name and description
    public BreathingActivity() : base()
    {
        string name = "Breathing Activity";
        string description="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        SetActivity(name, description);

        
    }

    // Main method to execute the breathing activity  
    public void DoBreathingActivity()
    {
        // Call the starting message from the parent class
        DisplayStartingMessage();

        // Ask user for duration
        Console.Write("How long, in seconds would you like for your session?:");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        // Display preparation message
        Console.Clear();
        Console.Write("Get ready...");
        Console.WriteLine();
        PauseWithSpinner(5);
        Console.WriteLine();

        // Calculate how many full breathing cycles fit into the session
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

        // Call the ending message from the parent class
        DisplayEndingMessage();
    }




}