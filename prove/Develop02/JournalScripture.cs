using System;
using System.IO;

public class answerYes{

    string dailyReading = Question1();
    string dailyLearning = Question2();
    string dailyExperience = Question3();
    
    string dailyGoal = Question4();

    string __saveJournal = Question5();

    

    public static string Question1()
    {
        Console.Write("What was your reading of the scriptures today? ");
        string reading = Console.ReadLine();

        return reading;
    }

    public static string Question2()
    {
        Console.Write("What did you learn from this reading?");
        string learning = Console.ReadLine();

        return learning;
    }

    public static string Question3()
    {
        Console.Write("Did you have an experience that reinforced your reading? Tell us");
        string experience = Console.ReadLine();

        return experience;
    }

   public  static string Question4()
    {
        Console.Write("What will be your goal this week according to what you have learned?");
        string ponder = Console.ReadLine();

        return ponder;
    }

    public static string Question5()
    {
        Console.Write("Type 1 to save your journal");
        string save = Console.ReadLine();
        return save;
              
        }
    
 

   public void DisplayResultJournal(string reading, string learning,string experience, string ponder)
    {
        Console.WriteLine($"My reading for this today was:{reading},");
        Console.WriteLine($"My learning from my reading was:{learning},");
        Console.WriteLine($"My experience about that reading was:{experience},");
        Console.WriteLine($"My goal from these scriptures is:{ponder},");
    }


    }




