using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Learn English Step By Step");


        Student student = new Student("", 0, 0);
        student.Register();

        List<AreaStudy> areas = new List<AreaStudy>
        {
            new BusinessArea(),
            new TravelArea(),
            new GeneralConversationArea(),
            new HealthArea ()

        };

        List<ProgressReport> progressReports = new List<ProgressReport>();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n Choose an option:");
            Console.WriteLine("1.-Start a lesson");
            Console.WriteLine("2.-Show simple summary report");
            Console.WriteLine("3.-Save progress report to file");
            Console.WriteLine("4.-Exit");
            Console.WriteLine("Option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {

                Console.WriteLine("\nSelect an area:");
                for (int i = 0; i < areas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {areas[i].GetAreaName()} - {areas[i].GetDescription()}");
                }
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
                Console.WriteLine("\nGenerating your progress summary...");
                ProgressReport.DisplaySimpleSummary(progressReports, student.GetLesson());
            }
            else if (option == "3")
            {
                foreach (ProgressReport report in progressReports)
                {
                    report.SaveToFile();
                }
            }
            else if (option == "4")
            {
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