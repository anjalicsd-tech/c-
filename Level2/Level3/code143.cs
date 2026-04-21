using System;
using System.Threading;

class Program
{
    // Method for Thread 1
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
            Thread.Sleep(500); // delay
        }
    }

    // Method for Thread 2
    static void PrintLetters()
    {
        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine("Letter: " + c);
            Thread.Sleep(500); // delay
        }
    }

    static void Main(string[] args)
    {
        // Creating threads
        Thread t1 = new Thread(PrintNumbers);
        Thread t2 = new Thread(PrintLetters);

        // Starting threads
        t1.Start();
        t2.Start();

        // Wait for threads to complete
        t1.Join();
        t2.Join();

        Console.WriteLine("Main thread finished");
    }
}