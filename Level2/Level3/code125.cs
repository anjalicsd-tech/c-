using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a List of integers
        List<int> numbers = new List<int>();

        // Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Display elements
        Console.WriteLine("List Elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Removing an element
        numbers.Remove(20);

        Console.WriteLine("\nAfter removing 20:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Access by index
        Console.WriteLine("\nFirst element: " + numbers[0]);
    }
}