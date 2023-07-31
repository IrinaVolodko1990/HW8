﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateDoubleArray(int row, int column)
{
    int[,] doubleArr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            doubleArr[i, j] = new Random().Next(0, 10);
        }
    }
    return doubleArr;
}
void PrintDoubleArray(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{doubleArr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SortingRowInDoubleArray(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    int tmp;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < column - 1; k++)
            {

                if (doubleArr[i, k] < doubleArr[i, k + 1])
                {
                    tmp = doubleArr[i, k];
                    doubleArr[i, k] = doubleArr[i, k + 1];
                    doubleArr[i, k + 1] = tmp;

                }
            }
        }
    }

    return doubleArr;
}
int[,] arr = CreateDoubleArray(4, 4);
PrintDoubleArray(arr);
Console.WriteLine();
SortingRowInDoubleArray(arr);
PrintDoubleArray(arr);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] CreateDoubleArray(int row, int column)
{
    int[,] doubleArr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            doubleArr[i, j] = new Random().Next(0, 10);
        }
    }
    return doubleArr;
}
void PrintDoubleArray(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{doubleArr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] FindSumElementInRow(int[,] doubleArr)
{
    int row = doubleArr.GetLength(0);
    int column = doubleArr.GetLength(1);
    int[] sumArray = new int[row];
    int rowSum = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            rowSum += doubleArr[i, j];
        }
        sumArray[i] = rowSum;
        rowSum = 0;
    }
    return sumArray;
}
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[,] doubleArray = CreateDoubleArray(3,2);
PrintDoubleArray(doubleArray);
int[] sumArray = FindSumElementInRow(doubleArray);
PrintArray(sumArray);