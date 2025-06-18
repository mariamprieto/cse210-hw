using System;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{


    private List<string> _prompt = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    };


    public ListingActivity() : base()

    {
        string name = "Listing Activity";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";


        SetActivity(name, description);



    }


    public void DoListingActivity()
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

        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"------{prompt}------");
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        int responses = CountUserResponses(GetDuration());
        Console.WriteLine($"\nYou listed {responses} items!");

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random _random = new Random();
        return _prompt[_random.Next(_prompt.Count)];
    }

    public int CountUserResponses(int duration)
    {
        int count = 0;
        
        DateTime futureTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("\n >");
            Console.ReadLine();
            count++;
        }
        return count;

    }
}