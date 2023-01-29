using System;
using System.IO;
public class answerNo
{
    // Declaration of variables

    string __challenges = "";
    string __plan = "";

    string __newChance = "";

    string __testimony = "";
    string __choice = "";



    //Methods that contain the questions the user asks to fill out the journal
    public string Question1()
    {
        Console.WriteLine("Tell me how your day was, what challenges did you have to read the scriptures? ");
        __challenges = Console.ReadLine();

        return __challenges;
    }

    public string Question2()
    {
        Console.WriteLine("What do you plan for tomorrow to read the scriptures? ");
        __plan = Console.ReadLine();

        return __plan;
    }

    public string Question3()
    {
        Console.WriteLine("What scripture will you choose to read tomorrow? ");
        __newChance = Console.ReadLine();

        return __newChance;
    }

    public string Question4()
    {
        Console.WriteLine("You can share your testimony about some principle that you have learned from scriptures ");
        __testimony = Console.ReadLine();

        return __testimony;
    }
    public string Question5()
    {
        Console.WriteLine("Good job! You have finished your diary today, do you want to save it or try again? ");


        return __choice;

    }

    public void DisplayChallenge()
    {


        Console.WriteLine($"{__challenges}");
        Console.WriteLine($"{__plan}");
        Console.WriteLine($"{__newChance}");
        Console.WriteLine($"{__testimony}");


    }

    public string SaveDisplayChallenge()
    {

        return $"{__challenges}~~{__plan}~~{__newChance}~~{__testimony}";

    }







}


