using System;

public class ReflectionActivity : Activity
{



    private List<string> _prompt = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity() : base()
    {
        string name = "Reflection Activity";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


        SetActivity(name, description);

        

    }

    public void DoReflectionActivity()
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
        

        DisplayPrompt();
        DisplayReflectionQuestions(GetDuration());
        DisplayEndingMessage();
}


    public string GetRandomPrompt()
    {
        Random _random = new Random();
        return _prompt[_random.Next(_prompt.Count)];
    }

    public string GetRandomQuestions()
    {
        Random _random = new Random();
        return _questions[_random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"------{prompt}------");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
       

    }
    public void DisplayReflectionQuestions(int duration)
    {
       
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string questions = GetRandomQuestions();
            Console.Write($"\n > {questions}");
            Console.WriteLine();
            PauseWithSpinner(5);
            
            
        }


    }


}