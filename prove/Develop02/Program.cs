using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
class Program
{
    private static string __path = @"C:\Users\user01\Desktop\cse210-hw\prove\Develop02\scripture.json";
    static void Main(string[] args)
    {
        Header headerJournal = new Header();
        headerJournal.nameUser();
        headerJournal.displayDate();
        headerJournal.DisplayWelcomeMessage();

        var scripture = GetScripture();
        DisplayScriptures(scripture);

    }

    private static void DisplayScriptures(string ComeFollowMeFile)
    {
        Console.WriteLine(ComeFollowMeFile);
        var scripture = Convert
    }

    private static string GetScripture()
    {
        string ComeFollowMeFile;
        using (var reader = new StreamReader(__path))
        {
            ComeFollowMeFile = reader.ReadToEnd();

        }
        return ComeFollowMeFile;

    }
}