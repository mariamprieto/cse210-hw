using System;

class Program
{
    static void Main(string[] args)
    {
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


            scripture.RandomHideWords(3);

        }
        Console.Clear();
        Console.WriteLine("Memorized Complete, try again with other scripture");

   } 
}