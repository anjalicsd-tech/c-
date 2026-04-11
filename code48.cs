using System;

class Program
{
    static void Main()
    {
        string name = "Anjali";
        int age = 20;

        // String Interpolation
        string message = $"My name is {name} and I am {age} years old.";

        Console.WriteLine(message);
    }
}