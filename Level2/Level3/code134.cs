using System;

// Declare delegate
delegate void MyDelegate(string message);

class Program
{
    // Method 1
    public static void ShowMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    // Method 2
    public static void ShowUpper(string msg)
    {
        Console.WriteLine("Upper: " + msg.ToUpper());
    }

    static void Main(string[] args)
    {
        // Create delegate instance
        MyDelegate del;

        // Assign method to delegate
        del = ShowMessage;
        del("Hello");

        // Change method
        del = ShowUpper;
        del("hello");

        // Multicast delegate (multiple methods)
        del = ShowMessage;
        del += ShowUpper;

        Console.WriteLine("\nMulticast Delegate:");
        del("welcome");
    }
}