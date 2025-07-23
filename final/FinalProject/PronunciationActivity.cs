
using System;
/// <summary>
/// Represents a pronunciation activity in a lesson.
/// The user is prompted to repeat key vocabulary words for practice.
/// </summary>
public class PronunciationActivity : Activity
{
    // Initializes the pronunciation activity with default estimated time and status.
    public PronunciationActivity()
    {
        SetName("Pronunciation");
        SetEstimatedTime(9);
        SetStatus("Not started");

    }

    // Starts the pronunciation activity by showing content and guiding the user
    // through repeating each pronunciation word from the lesson.
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