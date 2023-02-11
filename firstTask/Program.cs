﻿/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

double[,] InitMatrix (int row, int column)
{
    double[,] matrix = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble() * 100, 2);
        }
    }

    return matrix;
}

void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} | ");
        }
    Console.WriteLine();
    }
}

int row = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество колонок:");
double[,] matrix = InitMatrix(row, columns);
PrintMatrix(matrix);