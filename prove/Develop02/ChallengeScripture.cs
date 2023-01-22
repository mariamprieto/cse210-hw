using System;

public class answerNo
{

    string dailyChallenges = Question1();
    string dailyplan = Question2();
    string dailychoice = Question3();

    string dailyGoal = Question4();

    string saveJournal = Question5();


   


    public static string Question1()
    {
        Console.Write("Tell me how your day was, what challenges did you have to read the scriptures?");
        string challenges = Console.ReadLine();

        return challenges;
    }

    public static string Question2()
    {
        Console.Write("What do you plan for tomorrow to read the scriptures?");
        string plan = Console.ReadLine();

        return plan;
    }

    public static string Question3()
    {
        Console.Write("What scripture will you choose to read tomorrow?");
        string choice = Console.ReadLine();

        return choice;
    }

    public static string Question4()
    {
        Console.Write("You can share your testimony about some principle that you have learned from scriptures");
        string testimony = Console.ReadLine();

        return testimony;
    }
    public  static string Question5()
    {
        Console.Write("Type 1 to save your journal");
         string __save = Console.ReadLine();

        return __save;
    }

   
    


}


