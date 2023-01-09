using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int aNumber = -1;
        while (aNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string input = Console.ReadLine();
            aNumber = int.Parse(input);
            if (aNumber != 0)
            {
                numbers.Add(aNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}