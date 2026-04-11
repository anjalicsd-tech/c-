using System;

class Program
{
    static void Main()
    {
        double baseNum, exponent, result;

        Console.Write("Enter base: ");
        baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        exponent = Convert.ToDouble(Console.ReadLine());

        result = Math.Pow(baseNum, exponent);

        Console.WriteLine("Result = " + result);
    }
}