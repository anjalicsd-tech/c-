using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating ArrayList
        ArrayList list = new ArrayList();

        // Adding elements (different types allowed)
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);
        list.Add(true);

        // Display elements
        Console.WriteLine("ArrayList Elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Removing an element
        list.Remove("Hello");

        Console.WriteLine("\nAfter removing 'Hello':");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}