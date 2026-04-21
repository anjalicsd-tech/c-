using System;
using System.Threading;

class Counter
{
    private int count = 0;

    // Lock object
    private readonly object lockObj = new object();

    public void Increment()
    {
        for (int i = 0; i < 5; i++)
        {
            lock (lockObj)   // critical section
            {
                count++;
                Console.WriteLine("Count: " + count);
            }

            Thread.Sleep(100);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter c = new Counter();

        Thread t1 = new Thread(c.Increment);
        Thread t2 = new Thread(c.Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Count: Done");
    }
}