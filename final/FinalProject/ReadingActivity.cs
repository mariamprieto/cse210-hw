using System;
public class ReadingActivity : Activity
{
    public ReadingActivity()
    {
        SetName("Reading");
        SetEstimatedTime(20);
        SetStatus("Not started");

    }

    public override void Start(Lesson lesson)
    {
        ShowContent(lesson);
        Console.WriteLine("Please read the following text: \n");
        Console.WriteLine(lesson.GetReadingText());
        Console.WriteLine("Reading time: 20 minutes");

        for (int i = 20; i >= 1; i--)
        {
            Console.Write($"\rTime left: {i} minutes");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\nReading completed");
        SetActualTime(20);
        SetStatus("Completed");
    }
}