using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please write your score percentage: ");
        String score = Console.ReadLine();
        int x = int.Parse(score);
      


           if (x >= 70)
        {
            Console.WriteLine("Congratulations! You've passed this course.");
           
           if (x >= 90)
            { 
                string letter= "A";
                Console.WriteLine($"Your grade letter is {letter}.");
            }

            if ((x >= 80) && (x<90) )
            {
                string letter= "B";
                Console.WriteLine($"Your grade letter is {letter}.");
            }
            if ((x >= 70) && (x<80) )
            {
                string letter= "C";
                Console.WriteLine($"Your grade letter is {letter}.");
            }
        }

        else
        {
            Console.WriteLine("Sorry,your score wasn't enough to pass this course, don't give up and keep trying");
            if (x >= 60 && (x<70))
            {
                string letter= "D";
                Console.WriteLine($"Your grade letter is {letter}.");
            }
            if (x < 60)
            {
                string letter= "F";
                Console.WriteLine($"Your grade letter is {letter}.");
            }
        }
    }


}