using System;

class Program
{
    static void Main()
    {
        // Implicit Casting (small → large)
        int a = 10;
        double b = a;   // automatic conversion

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine("int value = " + a);
        Console.WriteLine("double value = " + b);

        // Explicit Casting (large → small)
        double x = 9.8;
        int y = (int)x;   // manual conversion

        Console.WriteLine("\nExplicit Casting:");
        Console.WriteLine("double value = " + x);
        Console.WriteLine("int value = " + y);
    }
}