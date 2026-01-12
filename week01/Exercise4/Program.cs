using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string numberStg = Console.ReadLine();
            userNumber = int.Parse(numberStg);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);

            }

        }

        // sum part

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // average part

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // max part

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}