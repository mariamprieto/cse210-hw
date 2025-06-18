using System;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{

    // List of prompts for the listing activity
    private List<string> _prompt = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    };

    // Constructor that sets the activity's name and description
    public ListingActivity() : base()

    {
        string name = "Listing Activity";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";


        SetActivity(name, description);

    }

    // Main method to execute the listing activity
    public void DoListingActivity()
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

        // Select a random prompt
        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"------{prompt}------");
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);

        // Collect user responses within the given time and count them
        int responses = CountUserResponses(GetDuration());
        Console.WriteLine($"\nYou listed {responses} items!");
        // Call the ending message from the parent class
        DisplayEndingMessage();
    }

    // Select a random prompt from the list
    public string GetRandomPrompt()
    {
        Random _random = new Random();
        return _prompt[_random.Next(_prompt.Count)];
    }

    // Method to count how many responses the user types in the given duration
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