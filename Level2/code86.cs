using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Convert to uppercase
        string upper = input.ToUpper();

        // Convert to lowercase
        string lower = input.ToLower();

        Console.WriteLine("Uppercase: " + upper);
        Console.WriteLine("Lowercase: " + lower);
    }
}