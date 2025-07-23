using System;

public class GrammarActivity : Activity
{
    public GrammarActivity()
    {

        SetName("Grammar");
        SetEstimatedTime(10);
        SetStatus("Not started");

    }
    public override void Start(Lesson lesson)
    {
        ShowContent(lesson);
        var sentences = lesson.GetGrammarSentences();

        foreach (var entry in sentences)
        {
            string sentence = entry.Key;
            string correctWord = entry.Value;
            int attempts = 0;
            string guess = "";
            int letters = 1;

            Console.WriteLine("Complete the sentece:");
            Console.WriteLine(sentence);

            while (guess.ToLower() != correctWord.ToLower())
            {
                Console.Write("Your guess:");
                guess = Console.ReadLine();
                attempts++;

                if (guess.ToLower() != correctWord.ToLower())
                {
                    Console.WriteLine("Incorrect.Try again");
                    if (letters < correctWord.Length)
                    {
                        letters++;

                    }

                    string hint = correctWord.Substring(0, letters).PadRight(correctWord.Length, '_');
                    Console.WriteLine($"Hint:{hint}");
                }
            }
            Console.WriteLine($"Correct! You guest it in {attempts} attempts");
        }
        Console.WriteLine("\nGrammar completed");
        SetActualTime(10);
        SetStatus("Completed");

    }
}
