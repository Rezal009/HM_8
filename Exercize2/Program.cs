// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 20, 4, 11, 2 },
            { 5, 1, 1, 3 },
            { 8, 50, 2, 4 },
            { 5, 52, 36, 7 }
        };

        int minRowIndex = FindRowWithMinSum(array);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int minSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}