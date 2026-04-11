using System;

class Program
{
    static void Main()
    {
        int choice;

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        int a = 10, b = 5;

        switch (choice)
        {
            case 1:
                Console.WriteLine("Addition = " + (a + b));
                break;

            case 2:
                Console.WriteLine("Subtraction = " + (a - b));
                break;

            case 3:
                Console.WriteLine("Multiplication = " + (a * b));
                break;

            case 4:
                Console.WriteLine("Division = " + (a / b));
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}