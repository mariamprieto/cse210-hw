using System;


    public class WritingAssignment : Assignment
    {
        private string __title;
    public WritingAssignment(string studentName, string topic, string title)  : base(studentName, topic)
    {
       
         __title = title;
    }

    public string GetWritingInformation()
        {

        string studentName = GetName ();

        return $"{__title} by {studentName}";
        }
    }



