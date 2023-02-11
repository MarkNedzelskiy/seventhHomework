/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int[,] InitMatrix (int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

void PrintMatrix (int[,] matrix)
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

double[] FindEverageForColumns (int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int tempSumm = 0;
        int columnsCount = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            tempSumm += matrix[j,i];
            columnsCount++;
        }
        array[i] = (double) tempSumm / columnsCount;
    }

    return array;
}

void PrintArray (double[] array)
{
    Console.Write("Среднее арифметическое каждой колонки: ");
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{Math.Round(array[i], 1)}.");
        else Console.Write($"{Math.Round(array[i], 1)}; ");
    }

    Console.WriteLine();
} 

int row = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество колонок:");
int[,] matrix = InitMatrix(row, columns);
PrintMatrix(matrix);
double[] array = FindEverageForColumns(matrix);
PrintArray(array);