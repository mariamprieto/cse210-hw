using System;

class Scripture
{

    //Definition of private variables that will store the details of the scriptures.

    private string __volume;
    private string __book;
    private int? __chapter;
    private int? __startVerse;
    private int? __endVerse;
    private string __text;

    //Constructor that stores the different contents of scriptures
    public Scripture()
    {
        __volume = "";
        __book = "";
        __chapter = null;
        __startVerse = null;
        __endVerse = null;
        __text = "";


    }

 

    public Scripture(string volume, string book, int chapter, int startVerse, string text)
    {
        __volume = volume;
        __book = book;
        __chapter = chapter;
        __startVerse = startVerse;
        __text = text;
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

    public string GetScriptureoneVerse()
    {

        return ($"{__volume},{__book} {__chapter}:{__startVerse}; {__text}");
    }
    public string GetScripturetwoVerse()
    {

        return ($"{__volume},{__book} {__chapter}:{__startVerse}-{__endVerse}; {__text}");
    }
}