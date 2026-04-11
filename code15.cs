using System;

class Program
{
    static void Main()
    {
        int num, original, remainder, result = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        while (num != 0)
        {
            remainder = num % 10;
            result += remainder * remainder * remainder; // cube of digit
            num = num / 10;
        }

        if (original == result)
        {
            Console.WriteLine("Armstrong Number");
        }
        else
        {
            Console.WriteLine("Not an Armstrong Number");
        }
    }
}