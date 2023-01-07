using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        string gradeScore;

        int x = int.Parse(grade);

        if (x >= 90)
        {
           gradeScore = "A";
            Console.WriteLine($"Your grade score is: {gradeScore}");
        }
        else if (x >=80)
        {
            gradeScore = "B";
            Console.WriteLine($"Your grade score is: {gradeScore}");
        }
        else if (x >= 70)
        {
            gradeScore = "C";
            Console.WriteLine($"Your grade score is: {gradeScore}");
        }
        else if (x >= 60)
        {
            gradeScore = "D";
            Console.WriteLine($"Your grade score is: {gradeScore}");
        }
        else
        {
            gradeScore = "F";
            Console.WriteLine($"Your grade score is: {gradeScore}");
        }
        if (gradeScore =="F")
        {
            Console.WriteLine("Your grade is not enough to pass this course, continue studying");
        }
        else
        {
            Console.WriteLine("Congratulations, you have passed this course");
        }

    }
}