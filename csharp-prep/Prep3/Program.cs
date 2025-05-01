using System;

class Program
{
    static void Main(string[] args)
    {
        /*Core 01
        int number=-1;
        int guess=0;

        while (number != guess)
        {
            Console.Write($"What is the magic number?: ");
            number = int.Parse(Console.ReadLine());
            
            Console.Write("What is your guess? : ");
            guess = int.Parse(Console.ReadLine());
           

            if (number > guess)
            {
                Console.Write("Higher");
            }

            else if (number < guess)
            {
                Console.Write("Lower");
            }
            else
            {
                Console.Write(" You guessed it!");
            }
            break;
        }*/

        /*Core 02
        int number;
        int guess = 0;
        Console.Write($"What is the magic number?: ");
        number = int.Parse(Console.ReadLine());
        
        while (number != guess)
        {
            Console.Write("What is your guess? : ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine(" You guessed it!");
            }
            
        }*/

        //Core 03

        Random randomGenerator = new Random();
        int numberCore = randomGenerator.Next(1, 100);
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        Console.Write("What is your guess? : ");
        string numberUse = Console.ReadLine();
        int numberGuess = int.Parse(numberUse);

        while (numberCore != numberGuess)
        {

            if (numberCore > numberGuess)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                numberGuess = int.Parse(Console.ReadLine());
            }
            else if (numberCore < numberGuess)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                numberGuess = int.Parse(Console.ReadLine());
            }


        }
   
                Console.WriteLine("You guessed it!");
            }


        /*Core 04

        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int numberCore = randomGenerator.Next(1, 100);
            int numberGuess = -1;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (numberCore != numberGuess)
            {
                Console.Write("What is your guess? : ");
                numberGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (numberCore > numberGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (numberCore < numberGuess)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }*/
}
