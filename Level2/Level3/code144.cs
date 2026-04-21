using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Task task1 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task 1: " + i);
                Task.Delay(500).Wait();
            }
        });

        // Task 2
        Task task2 = Task.Run(() =>
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine("Task 2: " + c);
                Task.Delay(500).Wait();
            }
        });

        // Wait for both tasks to complete
        Task.WaitAll(task1, task2);

        Console.WriteLine("All tasks completed");
    }
}