using System;

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

        Console.Write("How long, in seconds would you likefor your session?:");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

    }

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        return _prompt[_random.Next(_prompt.Count)];
    }

    public int CountUserResponses(int duration)
    {
        int count = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (startTime < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }
        return count;

}
}