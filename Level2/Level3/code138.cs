using System;

// Declare delegate
delegate void MyDelegate(string message);

class Program
{
    static void Main(string[] args)
    {
        // Anonymous method assigned to delegate
        MyDelegate del = delegate (string msg)
        {
            Console.WriteLine("Message: " + msg);
        };

        del("Hello Divya");

        // Another example with numbers
        Func<int, int> square = delegate (int x)
        {
            return x * x;
        };

        Console.WriteLine("Square: " + square(5));
    }
}