//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
    static void CheckArray(int[,] arr, int row, int colum)
    {
        if (arr.GetLength(0)<row || arr.GetLength(1)<colum)
        {
            Console.WriteLine("Такой позиции в массиве нет.");
        } 
        else
        {
            Console.WriteLine($"На позиции {row+1}, {colum+1} находится число {arr[row, colum]}" );
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку.");
        int m = Convert.ToInt32(Console.ReadLine())-1;
        Console.WriteLine("Введите Столбец.");
        int n = Convert.ToInt32(Console.ReadLine())-1;
        int[,] array = new int[5,5];

        
        FillArray(array);
        PrintArray(array);
        CheckArray(array, m, n);

    }
}