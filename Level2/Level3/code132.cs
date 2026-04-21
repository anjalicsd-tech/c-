using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Using Aggregate to calculate sum
        int sum = numbers.Aggregate((a, b) => a + b);

        Console.WriteLine("Sum: " + sum);

        // Using Aggregate to calculate product
        int product = numbers.Aggregate((a, b) => a * b);

        Console.WriteLine("Product: " + product);
    }
}