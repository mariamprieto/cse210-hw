using System;
using System.Runtime.CompilerServices;

/*
This program goes beyond the basic requirements by defining common methods, such as SetActivity and SetDuration, 
in the base Activity class and then reusing them in the derived classes (BreathingActivity, ReflectionActivity, and ListingActivity). 

An animated display was also added to help the user connect more deeply with each activity, creating a more engaging and mindful experience. 
Additionally, alerts were included to handle invalid menu options, improving user interaction and preventing errors.
*/
class Program
{
    static void Main(string[] args)
    {
        // Variable to store user's menu selection
        string choice = "";

        // Loop until the user chooses to quit
        while (choice != "4")
        {
            Console.Clear();// Clears the screen
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Select a choice from the menu:");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Create and run the Breathing Activity
                BreathingActivity breathing = new BreathingActivity();
                breathing.DoBreathingActivity();
            }
            else if (choice == "2")
            {
                // Create and run the Reflection Activity
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.DoReflectionActivity();
            }
            else if (choice == "3")
            {
                // Create and run the Listing Activity
                ListingActivity listing = new ListingActivity();
                listing.DoListingActivity();
            }
            else if (choice == "4")
            {
                // Exit message
                Console.WriteLine("Thank you for using the Mindfulness Program.Goodbye!");
                break;
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid option.");


            }
            // Pause before returning to the menu
            Console.WriteLine("\nPress enter to return to menu.");
            Console.ReadLine();

        }
    }
}