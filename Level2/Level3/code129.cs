using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 15, 20, 25, 30 };

        // Using WHERE (filter even numbers)
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Using SELECT (square of numbers)
        var squares = numbers.Select(n => n * n);

        Console.WriteLine("\nSquares of Numbers:");
        foreach (var num in squares)
        {
            Console.WriteLine(num);
        }
    }
}