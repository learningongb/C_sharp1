using System;
using static System.Console;

Clear();

const int countRows = 5;
const int countColumns = 5;

int row = Prompt("Введите номер строки (начиная с 0)");
int column = Prompt("Введите номер столбца (начиная с 0)");

double[,] matrix = GenerateMatrix(countRows, countColumns);

if (ValidateCell(matrix, row, column))
    WriteLine(matrix[row, column]);

bool ValidateCell(double[,] matrix, int i, int j)
{
    if (matrix.GetUpperBound(0) >= i && matrix.GetUpperBound(1) >= j)
        return true;
    WriteLine("Такой ячейки в массиве нет");
    return false;
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
