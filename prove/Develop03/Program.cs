using System;

class Program
{
    static void Main(string[] args)
    {

        // Menu to select the memorization speed
        Console.Clear();
        Console.WriteLine("=== Welcome to Scripture Memorizer ===\n");
        Console.WriteLine("Choose your memorization speed:");
        Console.WriteLine("1. Slow (1 word at a time)");
        Console.WriteLine("2. Slow (2 word at a time)");
        Console.WriteLine("3. Slow (3 word at a time)");
        Console.Write("Enter your choice: ");

        
        string option = Console.ReadLine();
        int _speed;

        if (option == "1")
        {
            _speed = 1;
        }
        else if (option == "2")
        {
            _speed = 2;
        }
        else if (option == "3")
        {
            _speed = 3;
        }
        else
        {
            Console.WriteLine("The option is invalid, start to slow model");
            _speed = 1;
        }
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.WordsHidden())
        {

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayScripture());
            Console.WriteLine("\n Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }


            scripture.RandomHideWords(_speed);

        }
        Console.Clear();
        Console.WriteLine("Memorized Complete, try again with other scripture");

   } 
}