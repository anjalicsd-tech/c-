using System;

class Program
{
    // Method with optional parameter
    static void DisplayDetails(string name, int age = 18, string city = "Nashik")
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine("----------------------");
    }

    static void Main()
    {
        // Passing all arguments
        DisplayDetails("Anjali", 20, "Pune");

        // Skipping optional parameters
        DisplayDetails("Rahul");

        // Passing one optional parameter
        DisplayDetails("Priya", 22);
    }
}