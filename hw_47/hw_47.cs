using System;
using static System.Console;

Clear();

const int accuracy = 1;

int countRows = Prompt("Введите количество строк");
int countColumns = Prompt("Введите количество столбцов");

PrintMatrix(GenerateMatrix(countRows, countColumns));

void PrintMatrix(double[,] matrix)
{
    int maxi = matrix.GetUpperBound(0);
    int maxj = matrix.GetUpperBound(1);
    for (int i = 0; i <= maxi; i++)
    {
        for (int j = 0; j <= maxj; j++)
        {
            Write($"{Math.Round(matrix[i, j], accuracy)} ");
        }
        WriteLine();
    }
}

double[,] GenerateMatrix(int countRows, int countColumns)
{
    double[,] matrix = new double[countRows, countColumns];
    Random random = new Random();
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
            matrix[i, j] = random.NextDouble();
        }
    }
    return matrix;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
