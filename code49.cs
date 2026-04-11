using System;

class Program
{
    static void Main()
    {
        double num1 = 16.0;
        double num2 = 3.5;

        Console.WriteLine("Square Root: " + Math.Sqrt(num1));
        Console.WriteLine("Power: " + Math.Pow(2, 3));
        Console.WriteLine("Absolute: " + Math.Abs(-10));
        Console.WriteLine("Ceiling: " + Math.Ceiling(num2));
        Console.WriteLine("Floor: " + Math.Floor(num2));
        Console.WriteLine("Round: " + Math.Round(num2));
        Console.WriteLine("Max: " + Math.Max(10, 20));
        Console.WriteLine("Min: " + Math.Min(10, 20));
    }
}