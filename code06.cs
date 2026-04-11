using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Number is Positive");
        }
        else if (num < 0)
        {
            Console.WriteLine("Number is Negative");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }
    }
}