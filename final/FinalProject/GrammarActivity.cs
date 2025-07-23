using System;

/// <summary>
/// Represents a grammar activity within a lesson.
/// This activity allows the user to complete grammar exercises by guessing missing words in sentences.
/// The system gives hints by gradually revealing letters of the correct answer.
/// </summary>
public class GrammarActivity : Activity
{
    public GrammarActivity()
    {

        // Sets the default values for this activity
        SetName("Grammar");
        SetEstimatedTime(10);
        SetStatus("Not started");

    }

    /// <summary>
    /// Starts the grammar activity by presenting incomplete sentences to the user,
    /// accepting guesses, providing hints, and tracking the number of attempts.
    /// </summary>
    public override void Start(Lesson lesson)
    {
        ShowContent(lesson);
        var sentences = lesson.GetGrammarSentences();// Get the dictionary of grammar sentences

        foreach (var entry in sentences)
        {
            string sentence = entry.Key;// The sentence with a missing word
            string correctWord = entry.Value;// The correct word to guess
            int attempts = 0;// Number of guesses made
            string guess = "";
            int letters = 1;// Number of letters to show as a hint


            Console.WriteLine("Complete the sentece:");
            Console.WriteLine(sentence);
            // Loop until the correct word is guessed
            while (guess.ToLower() != correctWord.ToLower())
            {
                Console.Write("Your guess:");
                guess = Console.ReadLine();
                attempts++;

                if (guess.ToLower() != correctWord.ToLower())
                {
                    Console.WriteLine("Incorrect.Try again");
                    // Reveal one more letter of the correct word with each incorrect attempt
                    if (letters < correctWord.Length)
                    {
                        letters++;

                    }
                    // Generate a hint with revealed letters and underscores
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
