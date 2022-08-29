// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;


class Program
{
    static void FillArray(int[,] arr)           
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j] = new Random().Next(1,50);
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
    static void CheckArray(int[,] arr)
    {
        double count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                count = count + arr[i,j];
                
            }
            count = Math.Round(count / arr.GetLength(1),3);
            Console.WriteLine($"Среднее арифметическое {i+1} столбца равно {count}");
        }
    }
    static void Main(string[] args)
    {

        int[,] array = new int[4,4];

        
        FillArray(array);
        PrintArray(array);
        CheckArray(array);

    }
}