using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Quit quit = new Quit();
        int selection = -1;

        while (selection != 5)
        {
            selection = DisplayMenu();
            if (selection == 1)
            {
                journal.AddEntry();
            }
            else if (selection == 2)
            {
                journal.DisplayRecord();
            }
            else if (selection == 3)
            {
                journal.SaveFile();
            }
            else if (selection == 4)
            {
                journal.LoadFile();
            }
            else if (selection == 5)
            {
                quit.MotivaToWrite();
                quit.SayGoodbye();
            }

            else
            {
                Console.WriteLine("The option is invalid, try again");
                selection = DisplayMenu();
            }
        }





    }
    public static int DisplayMenu()
    {
        Console.WriteLine("Welcometo the Journal Program!\n Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Save\n 4. Load \n 5. Quit");
        Console.WriteLine(" What do you like to do? : ");
        string _choice = Console.ReadLine();
        int _selection = int.Parse(_choice);

        if (_selection == 1 || _selection== 2 || _selection== 3 || _selection== 4 || _selection== 5)
        {
            return _selection;
        }
        else
        {
            Console.WriteLine("Invalid options");
            return -1;
        }
        
     }


}