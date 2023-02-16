using System;

class HideWords{

    private  Scripture scriptureText;

    public HideWords(string text){
       
        string[] scripture = text.Split(" ");
        int numPalabras = scripture.Count();
        int random = new Random().Next(0, numPalabras);

        foreach ( var scriptures in scripture ){

        }
        

    }

    
}