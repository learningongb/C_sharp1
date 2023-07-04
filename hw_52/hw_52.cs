using System;
using static System.Console;

Clear();

const int minValue = 1;
const int maxValue = 10;
const int accuracy = 1;
const int countRows = 5;
const int countColumns = 5;

int[,] matrix = GenerateMatrix(countRows, countColumns);
WriteLine("Исходный массив");
printMatrix(matrix);
double[] mean = ArithmeticMean(matrix);
WriteLine("Среднее арифметическое столбцов");
PrintArray(mean);

double[] ArithmeticMean(int[,] matrix) 
{
    int countRows = matrix.GetUpperBound(0) + 1;
    int countColumns = matrix.GetUpperBound(1) + 1;
    double[] sumColumns = new double[countColumns];
    for (int i = 0; i < countRows; i++) 
    {
        for (int j = 0; j < countColumns; j++) 
        {
            sumColumns[j] += matrix[i, j];
        }
    }
    for (int j = 0; j < countColumns; j++) 
    {
        sumColumns[j] /= countRows;
    }
    return sumColumns;
}

void PrintArray(double[] array) 
{
    foreach (var item in array)
    {
        Write($"{Math.Round(item, accuracy)} ");
    }
    WriteLine();
}

void printMatrix(int[,] matrix)
{
    int maxi = matrix.GetUpperBound(0);
    int maxj = matrix.GetUpperBound(1);
    for (int i = 0; i <= maxi; i++)
    {
        for (int j = 0; j <= maxj; j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}

int[,] GenerateMatrix(int countRows, int countColumns)
{
    int[,] matrix = new int[countRows, countColumns];
    Random random = new Random();
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
    return matrix;
}
