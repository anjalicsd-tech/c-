using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("Random Numbers:");

        for (int i = 1; i <= 5; i++)
        {
            int num = rand.Next(1, 100); // range: 1 to 99
            Console.WriteLine(num);
        }
    }
}