using System;

class Program
{
    // Method that takes array as parameter
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Array elements are:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Passing array to method
        PrintArray(numbers);
    }
}