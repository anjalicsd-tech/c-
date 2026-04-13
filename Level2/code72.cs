using System;

class Program
{
    // Method with 2 integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method with 3 integers
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method with double values
    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("Sum of 2 integers: " + Add(10, 20));
        Console.WriteLine("Sum of 3 integers: " + Add(10, 20, 30));
        Console.WriteLine("Sum of doubles: " + Add(5.5, 2.5));
    }
}