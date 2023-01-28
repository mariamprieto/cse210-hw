using System;



public class initialPrompt
{

    string __prompt = "";

    public string promptgenerator()

    {

        Console.Write("Did you read the scriptures today? Yes or No :");
        __prompt = Console.ReadLine();
        while (__prompt != "Yes" && __prompt != "No")
       { Console.Write("Please answer with Yes or No:");
            __prompt = Console.ReadLine();
        }
        

        return __prompt;

    }

    public void validation()
    {


        if (__prompt == "Yes")
        {
            answerYes Question = new answerYes();
            Question.Question1();
            Question.Question2();
            Question.Question3();
            Question.Question4();
            Question.Question5();
            
        }

        else 
        {
            answerNo Challenge = new answerNo();
            Challenge.Question1();
            Challenge.Question2();
            Challenge.Question3();
            Challenge.Question4();
            Challenge.Question5();
           
            
        }

       
    
    }

}