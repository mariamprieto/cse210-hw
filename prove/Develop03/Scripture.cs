using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture
{
    //Attributes that store script references and script text
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    public void RandomHideWords(int count)
    {

        int _visible = 0;

        foreach (var word in _words)
        {
            if (!word.isBlanked())
            {
                _visible++;
            }

        }

        int _toHide = Math.Max(count, _visible);
        int hidden = 0;

        while (hidden < count)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].isBlanked())
            {
                _words[index].Hide();
                hidden++;
            }

        }
               
    }

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