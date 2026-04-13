using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = a;   // copy of value

        b = 20;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}