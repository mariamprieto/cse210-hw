using System;

    public class MathAssignments : Assignment
    {
        private string __textbookSection;
        private string __problem;
        public MathAssignments(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
        {
            
            __textbookSection = textbookSection;
            __problem = problems;
        }

        public string GetHomeworkList(){

            return $" Section: {__textbookSection} Problems {__problem}";
        }
    }



