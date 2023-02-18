using System;

class Choices
{

    public string __choice;

   
    public void DisplayWelcomeMessage()
    {

        Console.WriteLine($"Welcome to your scripture  memorizer");

    }

    //Menu details
    public void OptionMenu()
    {

        DisplayMenu();
        while (__choice != "5")
        {

            __choice = Console.ReadLine();
            if (__choice == "1")
            {

                Scripture scriptureReference = new Scripture("Old testament","Proverbs", "3", "5", "6");
                Words scripture = new Words(scriptureReference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all ways acknowledge him and he shall direct thy paths.");
                HideWords scriptureMemorizer = new HideWords(scripture);

                string userInput = "";

                while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("{0} {1}", scriptureReference.GetScripturetwoVerse(), scriptureMemorizer.toString()));
                    Console.WriteLine();
                    Console.ReadLine();
                    scriptureMemorizer.removeWordsFromText();
                    
                }


            }

            else if (__choice == "2")
            {
                Scripture scriptureReference = new Scripture("Book of Mormon", "Nephi", "3", "7");
                Words scripture = new Words(scriptureReference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
                HideWords scriptureMemorizer = new HideWords(scripture);

                string userInput = "";

                while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("{0} {1}", scriptureReference.GetScriptureoneVerse(), scriptureMemorizer.toString()));
                    Console.WriteLine();
                    Console.ReadLine();
                    scriptureMemorizer.removeWordsFromText();

                }
              

            }
            else if (__choice == "3")

            {
                
                Scripture scriptureReference = new Scripture("New testament", "Matheus", "4", "4");
                Words scripture = new Words(scriptureReference, "But he answered and said, It is written, Man shall not live by bread alone, but by every word that proceedeth out of the mouth of God.");
                HideWords scriptureMemorizer = new HideWords(scripture);

                string userInput = "";

                while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("{0} {1}", scriptureReference.GetScriptureoneVerse(), scriptureMemorizer.toString()));
                    Console.WriteLine();
                    Console.ReadLine();
                    scriptureMemorizer.removeWordsFromText();
                }

            }
            else if (__choice == "4")
            {
                Scripture scriptureReference = new Scripture("Book of Mormon", "Alma", "5", "12", "13");
                Words scripture = new Words(scriptureReference, "And according to his faith there was a mighty change wrought in his heart.Behold I say unto you that this is all true.And behold, he preached the word unto your fathers, and a mighty change was also wrought in their hearts, and they humbled themselves and put their trust in the true and living God.And behold, they were faithful until the end; therefore they were saved.");
                HideWords scriptureMemorizer = new HideWords(scripture);

                string userInput = "";

                while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("{0} {1}", scriptureReference.GetScripturetwoVerse(), scriptureMemorizer.toString()));
                    Console.WriteLine();
                    Console.ReadLine();
                    scriptureMemorizer.removeWordsFromText();
                }
                
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
        Console.WriteLine("1 -- Proverbs 3:5-6");
        Console.WriteLine("2 -- 1 Nephi 3:7");
        Console.WriteLine("3 -- Matheus 4:4");
        Console.WriteLine("4 -- Alma 5:12-13 ");
        Console.WriteLine("5 -- Quit");


    }


}