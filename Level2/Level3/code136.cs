using System;

// Declare delegate
delegate void Notify();

// Publisher class
class Process
{
    public event Notify OnProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started...");
        
        // Simulate work
        Console.WriteLine("Process Completed!");

        // Raise event
        OnProcessCompleted?.Invoke();
    }
}

// Subscriber class
class Program
{
    public static void ShowMessage()
    {
        Console.WriteLine("Event received: Process is done!");
    }

    static void Main(string[] args)
    {
        Process p = new Process();

        // Subscribe to event
        p.OnProcessCompleted += ShowMessage;

        p.StartProcess();
    }
}