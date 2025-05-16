using System;
using System.Collections.Generic;

public class Entry
{
    //Stores the question show the user.
    public string _prompts;
    //Stores the date 
    public string _date;
    //Stores the answer from user
    public string _response;

    //Method that indicates the format in which the journal will be displayed in the console.
    public string GetDisplayText()
    {

        return $"{_date}:-Prompt:{_prompts} {_response}";
    }
    //Method that indicates the format in which the journal will be saved, separated by a comma
    public string SaveText()
    {
        return $"{_date},{_prompts},{_response}";
    }


    // Reads a line of text from a file 
    public void ReadFile(string text)
    {
        string[] parts = text.Split(',');
        _date = parts[0];
        _prompts = parts[1];
        _response = parts[2];
    }

}