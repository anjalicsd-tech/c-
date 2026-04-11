using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Break Example:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                break;  // stops loop

            Console.WriteLine(i);
        }

        Console.WriteLine("\nContinue Example:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;  // skips 5

            Console.WriteLine(i);
        }
    }
}