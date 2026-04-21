using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating HashSet
        HashSet<int> numbers = new HashSet<int>();

        // Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20);  // Duplicate (will not be added)

        Console.WriteLine("HashSet Elements:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Check element
        Console.WriteLine("\nContains 20? " + numbers.Contains(20));

        // Remove element
        numbers.Remove(10);

        Console.WriteLine("\nAfter removing 10:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}