using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 🔹 Func: takes input and returns value
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine("Sum: " + add(5, 3));

        // 🔹 Action: takes input but returns nothing (void)
        Action<string> greet = name => Console.WriteLine("Hello " + name);
        greet("Divya");

        // 🔹 Predicate: takes input and returns bool
        Predicate<int> isEven = n => n % 2 == 0;
        Console.WriteLine("Is 4 even? " + isEven(4));

        // Using Predicate with List
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> evenNumbers = numbers.FindAll(isEven);

        Console.WriteLine("Even Numbers:");
        evenNumbers.ForEach(n => Console.WriteLine(n));
    }
}