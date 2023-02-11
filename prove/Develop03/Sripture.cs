using System;

class Scripture
{

    //Definition of private variables that will store the details of the scriptures.

    private string __volume;
    private string __book;
    private int __chapter;
    private int __startVerse;
    private int __endVerse;
    private string __text;

    //Constructor that stores the different contents of scriptures
    public Scripture()
    {

    }

    public Scripture(string volume, string book, int chapter, int startVerse)
    {
        __volume = volume;
        __book = book;
        __chapter = chapter;
        __startVerse = startVerse;

    }

    public Scripture(string volume, string book, int chapter, int startVerse, int endVerse)
    {
        __volume = volume;
        __book = book;
        __chapter = chapter;
        __startVerse = startVerse;
        __endVerse = endVerse;
    }

    public Scripture(string volume, string book, int chapter, int startVerse, int endVerse, string text)
    {
        __volume = volume;
        __book = book;
        __chapter = chapter;
        __startVerse = startVerse;
        __endVerse = endVerse;
        __text = text;
    }

    public string GetScripture()
    {


        return "";
    }
}