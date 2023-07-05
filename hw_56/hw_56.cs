using System;
using static System.Console;

Clear();

const int minValue = 1;
const int maxValue = 10;
const int countRows = 5;
const int countColumns = 3;

int[,] matrix = GenerateMatrix(countRows, countColumns);
WriteLine("Исходный массив");
PrintMatrix(matrix);

int number = GetNumberRow(matrix);
Write("Строка с минимальной суммой элементов = ");
WriteLine(number);

int GetNumberRow(int[,] matrix)
{
    int number = -1;
    int minSum = 1000;
    int rows = matrix.GetUpperBound(0) + 1;
    int columns = matrix.GetUpperBound(1) + 1;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        if (number == -1 || sum < minSum)
        {
            number = i;
            minSum = sum;
        }
    }
    return number;
}

void PrintMatrix(int[,] matrix)
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
