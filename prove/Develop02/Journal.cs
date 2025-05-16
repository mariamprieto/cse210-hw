using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    //List that saves the entire journal
    private List<Entry> _entries = new List<Entry>();

    //Create an instance of the PromptGenerator class to be able to use its methods
    private PromptGenerator _promptGenerator = new PromptGenerator();

    //Adds entry of journal
    public void AddEntry()
    {
        //Get a random prompt
        string _prompt = _promptGenerator.GetRandomPrompt();

        //Write prompt in the console
        Console.WriteLine($"{_prompt}\n");
        //Store teh response
        string _response = Console.ReadLine();

        // Get current date as string
        string _date = DateTime.Now.ToShortDateString();

        //Create the new entry 
        Entry newEntry = new Entry
        {
            _date = _date,
            _prompts = _prompt,
            _response = _response

        };
        _entries.Add(newEntry);

    }
    public void DisplayRecord()
    {
         if (_entries.Count == 0)
    {
        Console.WriteLine("No journal entries found.");
        Console.WriteLine("Please load a file or start writing a new entry.");
    }
    else
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayText());
        }
    }
}
    public void SaveFile()
    {
        Console.WriteLine("Write a filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.SaveText());
            }
        }
        Console.WriteLine("Journal saved successfully");
    }

    public void LoadFile()
    {Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear(); // Clear existing entries

            foreach (string line in File.ReadLines(filename))
            {
                Entry entry = new Entry();
                entry.ReadFile(line); // Fill the entry from the text line
                _entries.Add(entry);  // Add to the list
            }

            Console.WriteLine(" Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine(" File not found.");
        }
        
    }
}