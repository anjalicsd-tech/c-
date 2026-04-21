using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();

        // 🔴 Slow method (String concatenation)
        sw.Start();
        string result1 = "";
        for (int i = 0; i < 10000; i++)
        {
            result1 += i;   // inefficient
        }
        sw.Stop();
        Console.WriteLine("Time (String): " + sw.ElapsedMilliseconds + " ms");

        // Reset stopwatch
        sw.Reset();

        // 🟢 Fast method (StringBuilder)
        sw.Start();
        StringBuilder result2 = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            result2.Append(i);   // efficient
        }
        sw.Stop();
        Console.WriteLine("Time (StringBuilder): " + sw.ElapsedMilliseconds + " ms");
    }
}