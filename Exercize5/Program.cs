// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] spiralArray = GenerateSpiralArray(n);

        PrintArray(spiralArray);
    }

    static int[,] GenerateSpiralArray(int n)
    {
        int[,] array = new int[n, n];
        int value = 1;
        int rowStart = 0;
        int rowEnd = n - 1;
        int colStart = 0;
        int colEnd = n - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = value++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = value++;
            }
            colEnd--;

            if (rowStart <= rowEnd)
            {
                for (int i = colEnd; i >= colStart; i--)
                {
                    array[rowEnd, i] = value++;
                }
                rowEnd--;
            }

            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    array[i, colStart] = value++;
                }
                colStart++;
            }
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}
