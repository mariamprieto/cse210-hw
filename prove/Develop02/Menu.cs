using System;

public class Menu
{

    // Declaration of variables
    string __name = "";
    string __choice = "";
    DateTime __date = DateTime.Now;

    //Object initialization
    initialPrompt InitialQuestion = new initialPrompt();



    //Empty method to display the current date
    public void displayDate()
    {
        Console.WriteLine($"Today is {__date} ");

    }
    // Empty method to welcome the user 
    public void DisplayWelcomeMessage()
    {

        Console.WriteLine($"Welcome to your scripture journal {__name}");

    }


    //Menu details
    public void OptionMenu()
    {

        while (__choice != "5")
        {
            DisplayMenu();
            __choice = Console.ReadLine();
            if (__choice == "1")
            {

                InitialQuestion.PromptGenerator();
                InitialQuestion.validation();
            }

            else if (__choice == "2")
            {

                Console.WriteLine($"I, {__name} today {__date}, my experience with the scriptures was:");
                InitialQuestion.DisplayJournal();

            }
            else if (__choice == "3")
            {
                InitialQuestion.SaveJournal();
            }
            else if (__choice == "4")
            {
                InitialQuestion.LoadJournal();

            }
            else if (__choice == "5")
            {
                Console.WriteLine("Goodbye");
                break;

            }

            else
            {
                Console.WriteLine("Choose a correct option");
            }

        }



    }
    //Method that obtains the username and returns it to the welcome, 
    //this name will be used to open the different journals according to the username
    public string nameUser()
    {

        Console.Write("Please enter your name: ");
        __name = Console.ReadLine();

        return __name;

    }


    //Static menu function
    static void DisplayMenu()
    {
        Console.WriteLine("Select one option ");
        Console.WriteLine("1 -- Write");
        Console.WriteLine("2 -- Display");
        Console.WriteLine("3 -- Save");
        Console.WriteLine("4 -- Load");
        Console.WriteLine("5 -- Exit");


    }




}