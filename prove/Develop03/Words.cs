using System;

class Words
{
    //Store the text of the scripture
    private string __text;
    //Search the class where we store the scripture reference
    private Scripture __scriptureReference;

    public Words(Scripture scriptureReference, string text)
    {
        __scriptureReference = scriptureReference;
        __text = text;
    }

  

    public string GetText(){
        return string.Format("{0}", __text);

    }
}