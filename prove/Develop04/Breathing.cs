using System;
public class Breathing: Activity
{
    private int _breathing;

    public Breathing(string activity, string description) : base(activity, description)
    {
        base.StartMessage();
        _breathing = base.GetTime() / 4;
        BeginActivity();
    }

    private void Countsecond()
    {
        
        int seconds = 5;
        Console.CursorVisible = false;

        while (seconds > 0)
        {
            Console.Write(seconds + "..");
            seconds--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }

    public void BeginActivity()
    {
        base.GetReady();
        Console.WriteLine();
        while (_breathing > 0)
        {
            Console.Write("Breath in... ");
            Countsecond();
            Console.WriteLine();
            _breathing--;
            Console.WriteLine();
            Console.Write("Breath out... ");
            Countsecond();
            Console.WriteLine();
            _breathing--;
            Console.WriteLine();
        }

        base.EndMessage();
        Menu menu = new Menu();
        menu.OptionMenu();
    }
}
