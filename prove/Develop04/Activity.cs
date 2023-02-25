using System;


public class Activity{

    //Declare variable 
        private string __activity;
        private string __description;
        private int __time;


        public Activity(string activity, string description)
        {
            __activity = activity;
            __description = description;
        }

        public void SetTime(int time){

        __time = time;
    }
        public int GetTime()
        {

            return __time;
        }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {__activity}");
        Console.WriteLine();
        Console.WriteLine(__description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        SetTime(Int32.Parse(Console.ReadLine()));
    }

    protected void GetReady()
    {
        Console.Clear();
        Console.Write("Get Ready...");
        Spinner(60);
        Console.WriteLine();
    }

    protected void Spinner(int count)

        { 
        while (count > 0)
        {
            Console.CursorVisible = false;

            Console.Write("| ");
            Thread.Sleep(100);
            count--;
            Console.Write("\b \b");
            Console.Write("\b \b");
            count--;

            Console.Write("/ ");
            Thread.Sleep(100);
            count--;
            Console.Write("\b \b");
            Console.Write("\b \b");
            count--;

            Console.Write("- ");
            Thread.Sleep(100);
            count--;
            Console.Write("\b \b");
            Console.Write("\b \b");
            count--;

            Console.Write("\\ ");
            Thread.Sleep(100);
            count--;
            Console.Write("\b \b");
            Console.Write("\b \b");
            count--;
        }
    }

    protected void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Spinner(60);
        Console.WriteLine($"You have completed {__time} seconds of the {__activity}");
        Spinner(60);
    }
}