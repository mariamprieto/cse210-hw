using System;
using System.Collections.Generic;

public class Reference
{
    // Stores the book, chapter, and verses
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse= verse;
        _endVerse= verse;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    
    // Return the reference in displayable format
    public string GetDisplayReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}: {_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        }
    }

}