using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DeserializeFromFile
{

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "scriptures.json";
            ReadJson readfile = new ReadJson ();
            string jsonString = File.ReadAllText(fileName);
            
            readfile = JsonSerializer.Deserialize<ReadJson>(jsonString );
          
          Console.WriteLine ($"Volume Book: {readfile.volume_title}");
            
            

            

        }
    }
}