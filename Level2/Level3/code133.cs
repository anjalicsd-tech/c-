using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 10, 15, 20 };

        // Using lambda to print elements
        numbers.ForEach(n => Console.WriteLine(n));

        // Using lambda to find even numbers
        var evenNumbers = numbers.FindAll(n => n % 2 == 0);

        Console.WriteLine("\nEven Numbers:");
        evenNumbers.ForEach(n => Console.WriteLine(n));
    }
}