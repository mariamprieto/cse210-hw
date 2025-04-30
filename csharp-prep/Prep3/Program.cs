using System;

class Program
{
    static void Main(string[] args)
    {
        //Core 01
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
        }


        //int number = randomGenerator.Next(1, 11);

        //Random randomGenerator = new Random();
        //Console.Write("What is your guess? : ");
        // string numberUse = Console.ReadLine();
        //int numberGuess = int.Parse(numberUse);

        //if (number > numberGuess)
        //{Console.Write($"What is the magic number?: {number}");
        //Console.Write(" Higher");}
        //else if (number < numberGuess)
        //{Console.Write($"What is the magic number?: {number}");
        //Console.Write(" Lower");}
        //else
        //{Console.Write($"What is the magic number?: {number}");
        //Console.Write(" You guessed it!");}

        //Core 02


        //int numberCore = randomGenerator.Next(1, 100);


        //while (numberCore != numberGuess)
        //{

        // if (numberCore > numberGuess)
        //{
        //Console.WriteLine("Higher");
        //Console.Write("What is your guess? ");
        //numberGuess = int.Parse(Console.ReadLine());
        //}
        //else if (numberCore<numberGuess)
        //{
        //Console.WriteLine("Lower");
        //Console.Write("What is your guess? ");
        //numberGuess = int.Parse(Console.ReadLine());
        //}
        //else
        //{
        //Console.WriteLine("You guessed it!");
        //}
        //}
    }
}
