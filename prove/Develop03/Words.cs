using System;
using System.Collections.Generic;


public class Word
{
    private string _text;
    private bool _hideWord;

    
    public Word(String text)
    {
        _text=text ;
        _hideWord = false;

    }
    public void Hide()
    {
        _hideWord = true;
    }
    public bool isBlanked()
    {
        return _hideWord;
    }
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