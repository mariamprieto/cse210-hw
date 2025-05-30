using System;
using System.Collections.Generic;


public class Scripture
{
    //Attributes that store script references and script text
    private Reference _reference;
    private List<Word> _words;
    // For selecting random words
    private Random _random = new Random();

    //Constructor for a scripture
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and store each as a Word object
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    // Hide a given number of words randomly
    public void RandomHideWords(int count)
    {

        int _visible = 0;
        // Count how many words are still visible
        foreach (var word in _words)
        {
            if (!word.isBlanked())
            {
                _visible++;
            }

        }
        // Determine how many words we can actually hide
        int _toHide = Math.Min(count, _visible);
        int hidden = 0;

        // Randomly hide eligible words
        while (hidden < _toHide)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].isBlanked())
            {
                _words[index].Hide();
                hidden++;
            }

        }

    }
    // Returns true if all words are hidden
    public bool WordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isBlanked())
            {
                return false;
            }
        }


        return true;

    }
    // Builds the display of the scripture 
    public string GetDisplayScripture()
    {
        string display = _reference.GetDisplayReference() + " ";
        foreach (var word in _words)
        {
            display += word.GetDisplayWord() + " ";
        }
        return display;
    }


}