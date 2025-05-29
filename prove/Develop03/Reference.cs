using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "Mateo";
        _chapter = 2;
        _startVerse = 10;
        _endVerse = 12;


    }
    public Reference(string book, int chapter, int verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _startVerse;
        endVerse = _endVerse;
     }

}