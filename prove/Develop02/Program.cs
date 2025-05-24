using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        // Create instances of Journal and Quit classes
        Journal journal = new Journal();
        Quit quit = new Quit();

        int selection = -1;

        //Displays the welcome message
        Console.WriteLine("Welcome to the Journal Program!\n");

        // Loop that keeps showing the menu until the user selects "5" to quit
        while (selection != 5)
        {
            selection = DisplayMenu();
            if (selection == 1)
            {
                // Option 1: Write a new journal entry
                journal.AddEntry();
            }
            else if (selection == 2)
            {
                // Option 2: Display existing journal entries
                journal.DisplayRecord();
            }
            else if (selection == 3)
            {
                // Option 3: Save journal entries to a file
                journal.SaveFile();
            }
            else if (selection == 4)
            {
                // Option 4: Load journal entries from a file
                journal.LoadFile();
            }
            else if (selection == 5)
            {
                // Option 5: Finish the journal and send a farewell and motivational message
                quit.MotivaToWrite();
                quit.SayGoodbye();
            }

            else
            {
                // Handle invalid option and prompt user again
                Console.WriteLine("The option is invalid, try again");
                selection = DisplayMenu();
            }
        }



    }
    // <summary>
    // Displays the main menu and reads the user's selection.
    // Returns an integer from 1 to 5, or -1 for invalid input.
    // </summary>
    // <returns>User's menu choice as an integer</returns>
    public static int DisplayMenu()
    {
        Console.WriteLine(" \n---------------------\n Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Save\n 4. Load \n 5. Quit");
        Console.WriteLine(" What do you like to do?");
        string _choice = Console.ReadLine();


        if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5")
        {
            return int.Parse(_choice);
        }

        else
        {
            Console.WriteLine("Invalid options");
            return -1;
        }

    }


}