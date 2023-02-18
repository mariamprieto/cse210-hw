using System;



    public class Assignment
    {

        private string __name;
        private string __topic;


    public Assignment(string studentName, string topic)
    {
        __name = studentName;
        __topic = topic;
    }
        public string GetName()
        {

            return __name;
        }

        
        public string GetTopic()
        {

            return __topic;
        }

        
        public string GetSummary()
        {

            return $"{__name} - {__topic}";
        }
    }
