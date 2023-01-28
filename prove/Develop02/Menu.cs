using System;

public class Menu
{

    // Declaration of variables
    string __name = "";
    string __choice = "";
    DateTime __date = DateTime.Now;


    initialPrompt InitialQuestion = new initialPrompt();



    //Empty method to display the current date
    public void displayDate()
    {
        Console.WriteLine($"Today is {__date} ");

    }
    // Empty method to welcome the user with menu details
    public void DisplayWelcomeMessage()
    {

        Console.WriteLine($"Welcome to your scripture journal {__name}");

    }

    public void OptionMenu()
    {

        while (__choice!="5")
        {
            DisplayMenu();
            __choice = Console.ReadLine();
            if (__choice == "1"){

                InitialQuestion.promptgenerator();
                InitialQuestion.validation();
            }

            else if(__choice=="2"){
                Console.WriteLine("Read file in process......");
            }
            else if (__choice == "3")
            {
                Console.WriteLine("Loading file in process......");
            }
            else if (__choice == "4")
            {
                Console.WriteLine("Saving file in process......");

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
    static void DisplayMenu (){
        Console.WriteLine("Select one option ");
        Console.WriteLine("1 -- Write");
        Console.WriteLine("2 -- Display");
        Console.WriteLine("3 -- Load");
        Console.WriteLine("4 -- Save");
        Console.WriteLine("5 -- Exit");

        
    }




}