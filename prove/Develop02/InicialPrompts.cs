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
            answerYes Reading = new answerYes();
            answerYes.Question1();
            answerYes.Question2();
            answerYes.Question3();
            answerYes.Question4();
            answerYes.Question5();
        

        }

        else 
        {
            answerNo Challenge = new answerNo();
            answerNo.Question1();
            answerNo.Question2();
            answerNo.Question3();
            answerNo.Question4();
            answerNo.Question5();
            
        }

       
    
    }

}