using System;
using System.Threading.Tasks;

class Program
{
    // Async method
    static async Task ShowMessage()
    {
        Console.WriteLine("Start");

        // Simulate delay
        await Task.Delay(2000);

        Console.WriteLine("End after 2 seconds");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Before calling async method");

        Task t = ShowMessage();  // calling async method

        Console.WriteLine("After calling async method");

        t.Wait();  // wait for async method to complete
    }
}