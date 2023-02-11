using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeserializeFromFile
{
   public class ReadJson
    {

        public string volume_title { get; set; }
        public string book_title { get; set; }
        public string book_short_title { get; set; }
        public int chapter_number { get; set; }
        public int verse_number { get; set; }
        public int verse_title { get; set; }
        public string verse_short_title { get; set; }
        public string scripture_texts { get; set; }

    }
}