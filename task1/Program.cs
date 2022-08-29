// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

using System;


class Program
{
    static void FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j] = new Random().Next();
            }
        }
    }
    static void PrintArray(int[,] arr)
    {
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
    }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк в массиве.");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в массиве.");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];

        PrintArray(array);
        FillArray(array);
        PrintArray(array);
    }
}