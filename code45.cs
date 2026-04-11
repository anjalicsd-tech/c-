using System;

// enum declaration
enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        Days today = Days.Wednesday;

        Console.WriteLine("Today is: " + today);

        // enum to integer
        int value = (int)today;
        Console.WriteLine("Numeric value = " + value);

        // integer to enum
        Days day = (Days)1;
        Console.WriteLine("Day for 1 = " + day);
    }
}