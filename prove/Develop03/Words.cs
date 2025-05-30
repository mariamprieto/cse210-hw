using System;
using System.Collections.Generic;


public class Word
{
    // Stores the text of the word and when it is hidden
    private string _text;
    private bool _hideWord;

    //Constructor for a text
    public Word(String text)
    {
        _text = text;
        _hideWord = false;

    }
    // Mark this word as hidden
    public void Hide()
    {
        _hideWord = true;
    }
    public bool isBlanked()
    {
        return _hideWord;
    }
    // Return either the original word or underscores if hidden
    public string GetDisplayWord()
    {
        if (_hideWord)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }


    }

}