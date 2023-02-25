using System;

public class Listing : Activity
{
    private List<string> __questions = new List<string>();
    private List<string> __answers = new List<string>();
   
    public Listing(string activity, string description) : base(activity, description)
    {
        Questions();
        base.StartMessage();
        StartActivity();
    }

    private void Questions()
    {
        __questions.Add("Who are people that you appreciate?");
        __questions.Add("What are personal strengths of yours?");
        __questions.Add("Who are people that you have helped this week?");
        __questions.Add("When have you felt the Holy Ghost this month?");
        __questions.Add("Who are some of your personal heroes?");
    }
    private string RandomPrompt()
    {
        Random random = new Random();
        int numQuestions = __questions.Count;
        int randomIndex = random.Next(0, numQuestions);
        string prompt = __questions[randomIndex];

        return prompt;
    }

    private void Count()
    {
        Console.CursorVisible = false;
        int seconds = 5;

        while (seconds > 0)
        {
            Console.Write(seconds + "..");
            seconds--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }

    private void StartActivity()
    {
        base.GetReady();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"{RandomPrompt()}");
        Console.Write("You may begin in: ");
        Count();
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(base.GetTime());
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            __answers.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {__answers.Count} items!");
        base.EndMessage();
        Menu menu = new Menu();
        menu.OptionMenu();
    }
}