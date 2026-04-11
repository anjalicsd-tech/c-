using System;

class Program
{
    static void Main()
    {
        // Nullable type using ?
        int? num = null;

        if (num.HasValue)
        {
            Console.WriteLine("Value = " + num.Value);
        }
        else
        {
            Console.WriteLine("Value is NULL");
        }

        // Assigning value later
        num = 10;
        Console.WriteLine("New Value = " + num);

        // Using null-coalescing operator
        int result = num ?? 0;
        Console.WriteLine("Result using ?? operator = " + result);
    }
}