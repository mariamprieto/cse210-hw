using System;

class Choices{

    public string __choice;
    public void DisplayWelcomeMessage()
    {

        Console.WriteLine($"Welcome to your scripture  memorizer");

    }

    //Menu details
    public void OptionMenu()
    {

        while (__choice != "5")
        {
            DisplayMenu();
            __choice = Console.ReadLine();
            if (__choice == "1")
            {


                Scripture reference = new Scripture("Book of Mormon", "Nephi", 3, 7, "A donde xxxxxxxxxx ccccccccccc cccccc cc c c");
                Console.WriteLine(reference.GetScriptureoneVerse());

            }

            else if (__choice == "2")
            {

                Scripture reference2 = new Scripture("Book of Mormon", "Proverbios", 3, 7, 8, "A donde  xxxxxx xxxxxxx xxxxxxx xxxxxxx");
                Console.WriteLine(reference2.GetScripturetwoVerse());
            }
            else if (__choice == "3")
            {
                Scripture reference2 = new Scripture("Book of Mormon", "Mateos", 3, 7, 8, "A donde xxxxxx xxxxxxx xxxxxxx xxxxxx ");
                Console.WriteLine(reference2.GetScripturetwoVerse());
            }
            else if (__choice == "4")
            {
                Scripture reference2 = new Scripture("Book of Mormon", "Salmos", 3, 7, 8, "A donde xxxxx xxxxxx xxxxxx xxxxxx xxxx ");
                Console.WriteLine(reference2.GetScripturetwoVerse());

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
    

    //Static menu function
    static void DisplayMenu()
    {
        Console.WriteLine("Select one option ");
        Console.WriteLine("1 -- 1 Nephy 3:7");
        Console.WriteLine("2 -- Proverbios 3:5-7");
        Console.WriteLine("3 -- Mateo 1:5");
        Console.WriteLine("4 -- Salmos 91:5 ");
        Console.WriteLine("5 -- Quit");


    }


}