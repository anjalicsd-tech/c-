using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        // Span (can modify)
        Span<int> span = arr;

        span[0] = 100;  // modifying original array

        Console.WriteLine("After Span modification:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        // ReadOnlySpan (cannot modify)
        ReadOnlySpan<int> roSpan = arr;

        Console.WriteLine("ReadOnlySpan values:");
        for (int i = 0; i < roSpan.Length; i++)
        {
            Console.Write(roSpan[i] + " ");
        }
    }
}