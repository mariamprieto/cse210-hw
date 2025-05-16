using System;
using System.Collections.Generic;

//This class presents two methods that will display farewell message in the console, when the user decides not to continue with the journal.
public class Quit
{
    // This method prints a goodbye message to the console
    public void SayGoodbye()
    {
        Console.WriteLine(" Goodbye!,Keep your journal updated!");
    }

    // This method prints a motivate message to the console
    public void MotivaToWrite()
    {
        Console.WriteLine(" Each day is a new adventure, filled with moments that slowly fade from memory over time.\n That’s why writing in your journal isn’t just a habit—it’s a gift to your future self.\n Every word you write is a way to relive what you’ve experienced,appreciate what you’ve felt,\n and hold on to the things time tries to erase.");
    }
}