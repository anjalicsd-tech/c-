using System;

// Custom Exception Class
class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int age = 15;

            if (age < 18)
            {
                // Throw custom exception
                throw new AgeException("Age must be 18 or above");
            }

            Console.WriteLine("Eligible");
        }
        catch (AgeException e)
        {
            Console.WriteLine("Custom Exception: " + e.Message);
        }
    }
}