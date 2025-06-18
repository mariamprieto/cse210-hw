using System;

public class ListingActivity : Activity
{
    public ListingActivity() : base()

    {
        string name = "Listing Activity";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";


        SetActivity(name, description);

        Console.Write("How long, in seconds would you likefor your session?:");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

    }
}
