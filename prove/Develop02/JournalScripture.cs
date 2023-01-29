using System;
using System.IO;

public class answerYes
{
    // Declaration of variables
    string __reading = "";
    string __learning = "";
    string __experience = "";
    string __ponder = "";
    string __choice = "";

  
    



    //Methods that contain the questions the user asks to fill out the journal
    public string Question1()
    {
        Console.WriteLine("What was your reading of the scriptures today? ");
        __reading = Console.ReadLine();

        return __reading;
    }

    public string Question2()
    {
        Console.WriteLine("What did you learn from this reading? ");
        __learning = Console.ReadLine();

        return __learning;
    }

    public string Question3()
    {
        Console.WriteLine("Did you have an experience that reinforced your reading? Tell us ");
        __experience = Console.ReadLine();

        return __experience;
    }

    public string Question4()
    {
        Console.WriteLine("What will be your goal this week according to what you have learned? ");
        __ponder = Console.ReadLine();

        return __ponder;
    }

    public string Question5()
    {
        Console.WriteLine("Good Job! You have finished your diary today, do you want to save it or try again? ");       
        return __choice;

    }


    public void DisplayScripture()
    {

        Console.WriteLine($"{__reading}");
        Console.WriteLine($"{__learning}");
        Console.WriteLine($"{__experience}");
        Console.WriteLine($"{__ponder}");

       
    }

    public string SaveDisplayScripture()
    {

        return $"{__reading}~~{__learning}~~{ __experience}~~{__ponder}";

      
    }

   
}




