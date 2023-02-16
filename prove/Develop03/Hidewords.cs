using System;

class HideWords{

    private string _text;

    public HideWords(string text){
       
        string[] scripture = text.Split(" ");
        int numPalabras = scripture.Count();
        int random = new Random().Next(0, numPalabras-2);

        foreach ( var scriptures in scripture ){

        }
        

    }

    
}