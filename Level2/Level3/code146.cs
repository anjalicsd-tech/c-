using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "sample.txt";

        // Writing to file
        File.WriteAllText(path, "Hello Divya!\nWelcome to C# File Handling.");

        Console.WriteLine("Data written to file.");

        // Reading from file
        string content = File.ReadAllText(path);

        Console.WriteLine("\nReading from file:");
        Console.WriteLine(content);
    }
}