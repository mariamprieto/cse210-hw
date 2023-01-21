using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


public class initialPrompt{

   

    public string __prompt = "";
    

    public string promptgenerator()
    {

        Console.Write("Did you read the scriptures today? Yes or No");
        __prompt = Console.ReadLine();

        return __prompt;

    }



}