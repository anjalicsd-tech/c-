using System;

class Program
{
    static void Main()
    {
        int totalDays, years, months, days;

        Console.Write("Enter number of days: ");
        totalDays = Convert.ToInt32(Console.ReadLine());

        years = totalDays / 365;
        totalDays = totalDays % 365;

        months = totalDays / 30;
        days = totalDays % 30;

        Console.WriteLine("Years = " + years);
        Console.WriteLine("Months = " + months);
        Console.WriteLine("Days = " + days);
    }
}