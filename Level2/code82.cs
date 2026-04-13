using System;

class Program
{
    static void Main()
    {
        int[] arr = { 12, 45, 7, 89, 34, 89, 23 };

        int first = int.MinValue;
        int second = int.MinValue;

        // Find first and second largest
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > first)
            {
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first)
            {
                second = arr[i];
            }
        }

        if (second == int.MinValue)
        {
            Console.WriteLine("No second largest element");
        }
        else
        {
            Console.WriteLine("Second Largest Element = " + second);
        }
    }
}