using System;
using System.Collections.Generic;

//Class that generates takes the stored questions, so that the user has greater ease in registering their journal.
public class PromptGenerator
{
    //List that stores all the questions created.
    private List<string> _prompts = new List<string>();

    //List initialization with 5 main questions
    public PromptGenerator()
    {
        _prompts.Add(" Who was the most interesting person I interacted with today?");
        _prompts.Add(" What was the best part of my day?");
        _prompts.Add(" How did I see the hand of the Lord in my life today?");
        _prompts.Add(" What was the strongest emotion I felt today?");
        _prompts.Add(" If I had one thing I could do over today, what would it be?");

    }

    // This method returns a random prompt from the list
    public string GetRandomPrompt()
    {
        Random question = new Random();
        int item = question.Next(_prompts.Count);
        return _prompts[item];
    }
}