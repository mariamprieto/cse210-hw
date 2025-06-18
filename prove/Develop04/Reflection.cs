using System;

public class ReflectionActivity : Activity
{


    public ReflectionActivity() : base()

    {
        string name = "Reflection Activity";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


        SetActivity(name, description);

        Console.Write("How long, in seconds would you likefor your session?:");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

    }

    
}