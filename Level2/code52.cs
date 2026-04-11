using System;

class Program
{
    static void Main()
    {
        int n, sum = 0;
        double average;

        Console.Write("Enter size of array: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        average = (double)sum / n;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}