using System;

// Declare delegate
delegate void MyDelegate();

class Program
{
    public static void Method1()
    {
        Console.WriteLine("Method 1 executed");
    }

    public static void Method2()
    {
        Console.WriteLine("Method 2 executed");
    }

    public static void Method3()
    {
        Console.WriteLine("Method 3 executed");
    }

    static void Main(string[] args)
    {
        MyDelegate del;

        // Assign methods to delegate
        del = Method1;
        del += Method2;
        del += Method3;

        // Calling multicast delegate
        del();
    }
}