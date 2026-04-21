using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating Dictionary (Key, Value)
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Adding elements
        students.Add(1, "Divya");
        students.Add(2, "Rahul");
        students.Add(3, "Amit");

        // Display elements
        Console.WriteLine("Student List:");
        foreach (KeyValuePair<int, string> kv in students)
        {
            Console.WriteLine("ID: " + kv.Key + " Name: " + kv.Value);
        }

        // Access by key
        Console.WriteLine("\nStudent with ID 2: " + students[2]);

        // Remove element
        students.Remove(3);

        Console.WriteLine("\nAfter removing ID 3:");
        foreach (var kv in students)
        {
            Console.WriteLine("ID: " + kv.Key + " Name: " + kv.Value);
        }
    }
}