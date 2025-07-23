using System;
using System.ComponentModel;

class Program
{
    /* Learn English Step by Step - Main Program

      This console application helps students learn English through structured lessons 
      categorized into areas such as Business, Travel, Health, and General Conversation.

     The user registers with a name, age, and number of lessons to take per area.
     Then, the application allows the student to:
        1. Select an area and begin lessons.
        2. Complete three types of activities per lesson: Reading, Grammar, and Pronunciation.
        3. Track progress and save a detailed report including time spent and grammar attempts.
        4. View a simple progress summary showing completed lessons by area.
        5. Export their progress to a text file.

     Lessons are considered complete only after finishing all three activities.
     Grammar activities track the number of attempts for accuracy.
     */

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Learn English Step By Step");

        // Register student
        Student student = new Student("", 0, 0);
        student.Register();

        // Initialize study areas
        List<AreaStudy> areas = new List<AreaStudy>
        {
            new BusinessArea(),
            new TravelArea(),
            new GeneralConversationArea(),
            new HealthArea ()

        };
        // Track progress per area
        List<ProgressReport> progressReports = new List<ProgressReport>();

        bool exit = false;
        while (!exit)
        {
            // Main menu
            Console.WriteLine("\n Choose an option:");
            Console.WriteLine("1.-Start a lesson");
            Console.WriteLine("2.-Show simple summary report");
            Console.WriteLine("3.-Save progress report to file");
            Console.WriteLine("4.-Exit");
            Console.WriteLine("Option: ");
            string option = Console.ReadLine();


            if (option == "1")
            {
                // Let the student choose an area and start a lesson
                Console.WriteLine("\nSelect an area:");
                for (int i = 0; i < areas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {areas[i].GetAreaName()} - {areas[i].GetDescription()}");
                }
                // Validate area selection
                Console.Write("Enter the number of the area: ");
                if (!int.TryParse(Console.ReadLine(), out int areaIndex) || areaIndex < 1 || areaIndex > areas.Count)
                {
                    Console.WriteLine("Invalid area selection. Please try again.");
                    continue;
                }

                areaIndex--;
                AreaStudy selectedArea = areas[areaIndex];
                string areaName = selectedArea.GetAreaName();
                Console.WriteLine("\n--------------------------------------------");
                //Get or create a progress report for the selected area
                ProgressReport report = null;

                foreach (ProgressReport r in progressReports)
                {
                    if (r.GetAreaName() == areaName)
                    {
                        report = r;
                        break;
                    }
                }
                if (report == null)
                {
                    report = new ProgressReport(areaName, new List<int>(), new Dictionary<string, int>(), new Dictionary<string, int>());
                    progressReports.Add(report);
                }

                int lessonNumber = report.GetNextLessonNuber(student.GetLesson());
                if (lessonNumber == -1) continue;

                Lesson lesson = selectedArea.GetLessons()[lessonNumber - 1];
                //Loop through activities until all are completed
                while (!lesson.IsFullyCompleted())
                {
                    lesson.ShowMenuActivities();
                    Console.WriteLine("Enter the activity name to start (Reading, Grammar, Pronunciation):");
                    string activityName = Console.ReadLine();
                    lesson.CompleteActivity(activityName);

                    if (!lesson.IsFullyCompleted())
                    {
                        Console.WriteLine("\nYou still have pending activities to complete this lesson.");
                    }
                }
                
                lesson.MarkAsCompleted();
                report.AddLessonResult(lesson);
                Console.WriteLine("\nLesson completed and saved to progress report.");
            }
            else if (option == "2")
            {
                // Show summary of student's progress in all areas
                Console.WriteLine("\nGenerating your progress summary...");
                ProgressReport.DisplaySimpleSummary(progressReports, student.GetLesson(), areas, student.GetName(), student.GetAge()); ;
            }
            else if (option == "3")
            {
                // Save progress to a file
                foreach (ProgressReport report in progressReports)
                {
                    report.SaveToFile();
                }
            }
            else if (option == "4")
            {
                // Exit the application
                Console.WriteLine("Goodbye! Keep practicing your English!");
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }


        }
    }
}