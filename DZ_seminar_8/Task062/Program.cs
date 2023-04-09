﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();


int[,] FillSpiralDoubleArray(int m, int n)
{

    int[,] result = new int[m, n];
    int i = 0;
    int j = 0;
    int s = 0;
    int res = 0;
    while (res < m * n)
    {
        while (j < (n - s) && result[i, j] == 0)
        {
            result[i, j] = res;
            res++;
            j++;
        }

        i = s + 1;
        j = j - 1;
        while (i < (m - s) && result[i, j] == 0)
        {
            result[i, j] = res;
            res++;
            i++;
        }

        i = i - 1;
        j = (n - 1) - s - 1;
        while (j > (s - 1) && result[i, j] == 0)
        {
            result[i, j] = res;
            res++;
            j--;
        }
        s++;

        j = j + 1;
        i = (m - 1) - s;
        while (i > (s - 1) && result[i, j] == 0)
        {
            result[i, j] = res;
            res++;
            i--;
        }

        i = i + 1;
        j = s;
    }
    return result;

}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //Write($" {inArray[i,j]} ");            
            Write("{0,2:F0} ", inArray[i, j]);
        }
        WriteLine();
    }
}



int[,] Array = FillSpiralDoubleArray(5, 7);

PrintArray(Array);
