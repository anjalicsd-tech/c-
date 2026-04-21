using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 20;
            int b = 0;

            int result = a / b;   // Exception (divide by zero)

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Finally block always executes");
        }

        Console.WriteLine("Program continues...");
    }
}