using System;
using System.IO;

public class answerYes
{

    string __reading = "";
    string __learning = "";
    string __experience = "";
    string __ponder = "";
    string __choice = "";




    public string Question1()
    {
        Console.Write("What was your reading of the scriptures today? ");
        __reading = Console.ReadLine();

        return __reading;
    }

    public string Question2()
    {
        Console.Write("What did you learn from this reading?");
        __learning = Console.ReadLine();

        return __learning;
    }

    public string Question3()
    {
        Console.Write("Did you have an experience that reinforced your reading? Tell us");
        __experience = Console.ReadLine();

        return __experience;
    }

    public string Question4()
    {
        Console.Write("What will be your goal this week according to what you have learned?");
        __ponder = Console.ReadLine();

        return __ponder;
    }

    public string Question5()
    {
        Console.Write("Good Job! You have finished your diary today, do you want to save it or try again? ");

      
                   
        return __choice;

    }



}




