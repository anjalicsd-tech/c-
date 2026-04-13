using System;

class Program
{
    static void Main()
    {
        string name = "Anjali";
        int age = 20;
        double marks = 85.5;

        // 1. Using concatenation
        Console.WriteLine("Name: " + name + ", Age: " + age);

        // 2. Using string.Format()
        Console.WriteLine(string.Format("Name: {0}, Age: {1}, Marks: {2}", name, age, marks));

        // 3. Using string interpolation (best method)
        Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");
    }
}