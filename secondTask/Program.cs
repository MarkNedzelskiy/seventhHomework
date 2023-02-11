/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
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

void FindElement (double[,] matrix)
{
    int row = GetNumber("На какой строке находится элемент?");
    int column = GetNumber("В какой колонке находится элемент?");

    if ((row < matrix.GetLength(0) && row >= 0)
        && (column < matrix.GetLength(1) && column >= 0)) Console.WriteLine(matrix[row, column]);
    else Console.WriteLine("такого элемента нет");

}

int row = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество колонок:");
double[,] matrix = InitMatrix(row, columns);
PrintMatrix(matrix);
FindElement(matrix);