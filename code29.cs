using System;

class Program
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // if - else if - else
        if (num > 0)
        {
            Console.WriteLine("Positive Number");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negative Number");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        // switch statement
        Console.WriteLine("\nSwitch Example:");
        switch (num)
        {
            case 1:
                Console.WriteLine("Number is One");
                break;
            case 2:
                Console.WriteLine("Number is Two");
                break;
            default:
                Console.WriteLine("Number is not 1 or 2");
                break;
        }
    }
}