using System;

class Program
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[rows, cols];
        int[,] transpose = new int[cols, rows];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Transpose logic
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = a[i, j];
            }
        }

        Console.WriteLine("Transpose of Matrix:");

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(transpose[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}