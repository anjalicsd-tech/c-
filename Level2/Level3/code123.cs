using System;

class Program
{
    static void CheckNumber(int num)
    {
        if (num < 0)
        {
            // Throwing exception manually
            throw new Exception("Number cannot be negative");
        }

        Console.WriteLine("Number is valid: " + num);
    }

    static void Main(string[] args)
    {
        try
        {
            CheckNumber(-5);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}