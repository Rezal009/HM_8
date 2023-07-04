// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




using System;

class Program
{
    static void Main()
    {
        int[,,] array = GenerateArray(2, 2, 2);

        PrintArrayWithIndices(array);
    }

    static int[,,] GenerateArray(int size1, int size2, int size3)
    {
        int[,,] array = new int[size1, size2, size3];
        int number = 10;

        for (int i = 0; i < size1; i++)
        {
            for (int j = 0; j < size2; j++)
            {
                for (int k = 0; k < size3; k++)
                {
                    array[i, j, k] = number;
                    number++;
                }
            }
        }

        return array;
    }

    static void PrintArrayWithIndices(int[,,] array)
    {
        int size1 = array.GetLength(0);
        int size2 = array.GetLength(1);
        int size3 = array.GetLength(2);

        for (int i = 0; i < size1; i++)
        {
            for (int j = 0; j < size2; j++)
            {
                for (int k = 0; k < size3; k++)
                {
                    Console.Write(array[i, j, k]);
                    Console.Write("(" + i + "," + j + "," + k + ") ");
                }
                Console.WriteLine();
            }
        }
    }
}