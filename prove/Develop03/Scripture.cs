using System;
using System.Collections.Generic;

public class Scripture
{
    //Attributes that store script references and script text
    private string _reference;
    private string _words;

    public Scripture()
    {
        _reference = "Job 1:5";
        _words = "Si todos ....";

    }

    public Scripture(string reference, string text) {
        reference = _reference;
        text = _words;

    }
   
    


}