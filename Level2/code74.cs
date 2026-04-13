using System;

class Program
{
    // Recursive method to find Fibonacci number
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;   // Base case
        else if (n == 1)
            return 1;   // Base case
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive call
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}