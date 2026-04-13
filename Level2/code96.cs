using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 2, 5, 3, 6 };

        Console.WriteLine("Duplicate elements:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.Write(arr[i] + " ");
                    break; // avoid printing same duplicate multiple times
                }
            }
        }
    }
}