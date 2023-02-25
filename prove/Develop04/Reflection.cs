using System;

public class Reflection : Activity
{
    private List<string> __startMessage = new List<string>();
    private List<string> __questions = new List<string>();
    private int __numQuestions;

    private void ListReflection()
    {
        __startMessage.Add("Think of a time when you stood up for someone else.");
        __startMessage.Add("Think of a time when you did something really difficult.");
        __startMessage.Add("Think of a time when you helped someone in need.");
        __startMessage.Add("Think of a time when you did something truly selfless.");

    }
    private void QuestionsReflection()
    {
        __questions.Add("Why was this experience meaningful to you?");
        __questions.Add("Have you ever done anything like this before?");
        __questions.Add("How did you get started?");
        __questions.Add("How did you feel when it was complete?");
        __questions.Add("What made this time different than other times when you were not as successful?");
        __questions.Add("What is your favorite thing about this experience?");
        __questions.Add("What could you learn from this experience that applies to other situations?");
        __questions.Add("What did you learn about yourself through this experience?");
        __questions.Add("How can you keep this experience in mind in the future?");
    }

    public Reflection(string activity, string description) : base(activity, description)
    {
        ListReflection();
        QuestionsReflection();
        base.StartMessage();
        __numQuestions = base.GetTime() / 10;
        StartActivity();
    }

    private string RandomStart()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, __startMessage.Count);
        string start = __startMessage[randomIndex];

        return start;
    }

    private string RandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, __questions.Count);
        string question = __questions[randomIndex];

        return question;
    }

    private void StartActivity()
    {
        base.GetReady();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {RandomStart()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
        while (__numQuestions > 0)
        {
            Console.Write($"> {RandomQuestion()} ");
            base.Spinner(190);
            __numQuestions--;
            Console.WriteLine();
        }
        Console.WriteLine();
        base.EndMessage();
        Menu menu = new Menu();
        menu.OptionMenu();
    }
}