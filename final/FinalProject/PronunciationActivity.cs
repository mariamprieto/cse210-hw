
using System;
public class PronunciationActivity : Activity
{
    public PronunciationActivity()
    {
        SetName("Pronunciation");
        SetEstimatedTime(9);
        SetStatus("Not started");

    }

    public override void Start(Lesson lesson)
    {
        ShowContent(lesson);

        foreach (var word in lesson.GetPronunciationWords())
        {
            Console.WriteLine($"Repeat after me:{word}");
            for (int i = 3; i >= 1; i--)
            {
                Console.Write($"\rTime left: {i} minutes");
                Thread.Sleep(1000);
            }


        }
        Console.WriteLine("\nPronunciation completed");
        SetActualTime(9);
        SetStatus("Completed");
    }


}