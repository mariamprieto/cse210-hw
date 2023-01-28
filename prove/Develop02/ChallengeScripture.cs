using System;

public class answerNo
{

    string __challenges = "";
    string __plan = "";

    string __newChance = "";

    string __testimony = "";
    string __choice="";




    public string Question1()
    {
        Console.Write("Tell me how your day was, what challenges did you have to read the scriptures?");
        __challenges = Console.ReadLine();

        return __challenges;
    }

    public string Question2()
    {
        Console.Write("What do you plan for tomorrow to read the scriptures?");
        __plan = Console.ReadLine();

        return __plan;
    }

    public string Question3()
    {
        Console.Write("What scripture will you choose to read tomorrow?");
        __newChance = Console.ReadLine();

        return __newChance;
    }

    public string Question4()
    {
        Console.Write("You can share your testimony about some principle that you have learned from scriptures");
        __testimony = Console.ReadLine();

        return __testimony;
    }
    public string Question5()
    {
        Console.Write("Good job! You have finished your diary today, do you want to save it or try again? ");
      

        return __choice;

    }






}


