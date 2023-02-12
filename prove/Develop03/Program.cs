using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DeserializeFromFile
{

    class Program
    {
        static void Main(string[] args)
        {

            Scripture reference = new Scripture("Book of Mormon","Nephi", 3,7, "A donde");
            Console.WriteLine(reference.GetScriptureoneVerse ());

            Scripture reference2 = new Scripture("Book of Mormon", "Nephi", 3, 7,8, "A donde");
            Console.WriteLine(reference2.GetScripturetwoVerse());


        }
    }
}