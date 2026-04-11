using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        // Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a > b = " + (a > b));
        Console.WriteLine("a < b = " + (a < b));
        Console.WriteLine("a == b = " + (a == b));
        Console.WriteLine("a != b = " + (a != b));

        // Logical Operators
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("(a > b && b > 0) = " + (a > b && b > 0));
        Console.WriteLine("(a > b || b < 0) = " + (a > b || b < 0));
        Console.WriteLine("!(a > b) = " + !(a > b));

        // Increment / Decrement
        Console.WriteLine("\nIncrement / Decrement:");
        Console.WriteLine("a++ = " + (a++));
        Console.WriteLine("After a++: " + a);
        Console.WriteLine("--b = " + (--b));
    }
}