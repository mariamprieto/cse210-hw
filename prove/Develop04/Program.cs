using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DoBreathingActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.DoReflectionActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.DoListingActivity();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Press enter to try again.");
                Console.ReadLine();

            }
            Console.WriteLine("\n Press enterto return to menu.");
            Console.ReadLine();

        }
    }
}