using System;

using System;

class Scripture
{

    //Definition of private variables that will store the details of the scriptures.

    private string __volume;
    private string __book;
    private string __chapter;
    private string __startVerse;
    private string __endVerse;
   

    //Constructor that stores the different contents of scriptures
    public Scripture()
    {
        __volume = "";
        __book = "";
        __chapter = null;
        __startVerse = null;
        __endVerse = null;
      


    }



    public Scripture(string volume, string book, string chapter, string startVerse)
    {
        __volume = volume;
        __book = book;
        __chapter = chapter;
        __startVerse = startVerse;
       
    }

    public Scripture(string volume, string book, string chapter, string startVerse, string endVerse)
    {
        __volume = volume;
        __book = book;
        __chapter = chapter;
        __startVerse = startVerse;
        __endVerse = endVerse;
        
    }

    public string GetScriptureoneVerse()
    {

        return string.Format("{0},{1},{2}:{3}",__volume, __book, __chapter, __startVerse);
    }
    public string GetScripturetwoVerse()
    {

        return string.Format("{0},{1},{2}:{3}-{4}", __volume, __book, __chapter, __startVerse,__endVerse);
    }
}