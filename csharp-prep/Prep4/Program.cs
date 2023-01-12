using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {


        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished ");
        string numberList = (Console.ReadLine());
        int number = int.Parse(numberList);
        numbers.Add(number);

        while (number != 0)
        {
            Console.Write("Enter a number:  ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int numberUser in numbers)
        {
            sum += numberUser;
        }

        Console.WriteLine($"The sum is: {sum}");

        float averageNumber = (sum / numbers.Count);
        Console.WriteLine($"The average is: {averageNumber}");

        int max = numbers[0];

        foreach (int numberUser in numbers)
        {
            if (numberUser > max)
            {
                max = numberUser;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}