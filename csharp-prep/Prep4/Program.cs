using System;
using System.Globalization;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        //Create a list
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
         // Step 1: Collect numbers
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Step 2: Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Step 3: Compute the average
        float average = 0;
        if (numbers.Count > 0)
        {
            average = (float)sum / numbers.Count;
        }

        // Step 4: Find the maximum
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}