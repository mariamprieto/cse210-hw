using System;

public class Header
{


    // Declaration of attributes
    public string __name = "";
    DateTime __date = DateTime.Now;

    public void displayDate()
    {

        Console.WriteLine($"Today is {__date} ");

    }
    // Welcome message
    public void DisplayWelcomeMessage()
    {

        Console.WriteLine($"Welcome to your scripture journal {__name}");
    }

    public string nameUser()
    {

        Console.Write("Please enter your name: ");
        __name = Console.ReadLine();

        return __name;

    }



}