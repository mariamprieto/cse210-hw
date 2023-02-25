using System;

public class Menu
{

    // Declaration of variables
   
    string __choice = "";
    

    //Menu details
    public void OptionMenu()
    {
        DisplayMenu();

        while (__choice != "4")
        {
            
            __choice = Console.ReadLine();
            if (__choice == "1")
            {

                Breathing breath = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            }

            else if (__choice == "2")
            {

                Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                

            }
            else if (__choice == "3")
            {
                Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }
            
            else if (__choice == "4")
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


    //Static menu function
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
    }




}