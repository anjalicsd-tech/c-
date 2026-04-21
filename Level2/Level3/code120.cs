using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;

            int result = a / b;   // This will cause exception

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }

        Console.WriteLine("Program continues...");
    }
}