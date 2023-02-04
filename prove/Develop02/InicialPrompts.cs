using System;
using System.IO;




public class initialPrompt
{
    // Declaration of variables
    string __respond = "";
    
    answerYes Question = new answerYes();
    answerNo Challenge = new answerNo();
    string fileName = "myFile.txt";
    

    //Method that verifies if the user read the scripts or not, to determine the questions that will be asked
    public string PromptGenerator()

    {

        Console.Write("Did you read the scriptures today? Yes or No: ");
        __respond = Console.ReadLine();
        while (__respond != "Yes" && __respond != "No")
        {
            Console.Write("Please answer with Yes or No: ");
            __respond = Console.ReadLine();
        }


        return __respond;

    }

    //Initialization of the object that determines the questions according to the previous answer of the user
    public void validation()
    {


        if (__respond == "Yes")
        {
          
            Question.Question1();
            Question.Question2();
            Question.Question3();
            Question.Question4();
            Question.Question5();


        }

        else
        {
            
            Challenge.Question1();
            Challenge.Question2();
            Challenge.Question3();
            Challenge.Question4();
            Challenge.Question5();


        }



    }

    public void DisplayJournal()
    {


        if (__respond == "Yes")
        {
            
            Question.DisplayScripture();

        }

        else
        {
            Challenge.DisplayChallenge();


        }

    }


    public void SaveJournal()
    {

         
        if (__respond == "Yes")
        {

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {

                // You can use the $ and include variables just like with Console.WriteLine
             
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{Question.SaveDisplayScripture()}");

            }


        }

        else
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{Challenge.SaveDisplayChallenge()}");
            }



        }

    }
    public void LoadJournal()
    {

        string line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C:\\Users\\user01\\Desktop\\cse210-hw\\prove\\Develop02\\myFile.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }


}