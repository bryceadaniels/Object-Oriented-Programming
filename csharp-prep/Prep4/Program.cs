using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        while (number != 0)
        {
        Console.Write("Enter a number: ");
        string numberString = Console.ReadLine();
        number = int.Parse(numberString);
        if (number != 0)
        {
            numbers.Add(number);
        }
        }
        int sum = 0;
        int largestNumber = 0;
        int smallestPositive = 100000000;
        foreach(int numberInList in numbers)
        {
            sum += numberInList;
            if (numberInList > largestNumber)
            {
                largestNumber = numberInList;
            }
            if (numberInList > 0)
            {
                if (numberInList < smallestPositive)
                {
                    smallestPositive = numberInList;
                }
            }
        }
        numbers.Sort();
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum} ");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The largest number is: {largestNumber} ");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.Write($"{num},");
        }
    }
}