using System;

// Static class for extension method
public static class StringExtension
{
    // Extension method
    public static string ToUpperCustom(this string str)
    {
        return str.ToUpper();
    }
}

class Program
{
    static void Main(string[] args)
    {
        string name = "divya";

        // Calling extension method
        string result = name.ToUpperCustom();

        Console.WriteLine("Result: " + result);
    }
}