using System;

/// <summary>
/// Represents a reading activity where the student is asked to read a provided text.
/// Simulates a countdown to represent estimated reading time.
/// </summary>
public class ReadingActivity : Activity
{
    // Initializes the reading activity with a default estimated time and status.
    public ReadingActivity()
    {
        SetName("Reading");
        SetEstimatedTime(20);
        SetStatus("Not started");

    }
    // Starts the reading activity by displaying the lesson's reading text and a timer.
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