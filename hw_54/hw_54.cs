using System;
using static System.Console;
// using System.Collections;

Clear();

const int minValue = 1;
const int maxValue = 10;
const int countRows = 5;
const int countColumns = 5;

int[,] matrix = GenerateMatrix(countRows, countColumns);
WriteLine("Исходный массив");
PrintMatrix(matrix);

SortArray(matrix);
WriteLine("Отсортированный массив");
PrintMatrix(matrix);

void SortArray(int[,] row)
{
    int countRows = matrix.GetUpperBound(0) + 1;
    int countColumns = matrix.GetUpperBound(1) + 1;
    for (int rowIndex = 0; rowIndex < countRows; rowIndex++)
    {
        for (int i = 0; i < countColumns; i++)
        {
            int indexMin = i;
            int valueMin = row[rowIndex, i];

            for (int j = i + 1; j < countColumns; j++)
            {
                if (row[rowIndex, j] < valueMin)
                {
                    indexMin = j;
                    valueMin = row[rowIndex, j];
                }
            }
            if (indexMin != i)
            {
                int tmp = row[rowIndex, i];
                row[rowIndex, i] = row[rowIndex, indexMin];
                row[rowIndex, indexMin] = tmp;
            }
        }
    }
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
