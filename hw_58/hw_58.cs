using System;
using static System.Console;

Clear();

const int minValue = 1;
const int maxValue = 10;
const int countRows1 = 5;
const int countColumns1 = 8;
const int countRows2 = 8;
const int countColumns2 = 2;

int[,] matrix1 = GenerateMatrix(countRows1, countColumns1);
// int[,] matrix1 = new int[4, 4]
// {{1, 4, 7, 2},
// {5, 9, 2, 3},
// {8, 4, 2, 4},
// {5, 2, 6, 7}};
WriteLine("Исходная матрица 1");
PrintMatrix(matrix1);

int[,] matrix2 = GenerateMatrix(countRows2, countColumns2);
// int[,] matrix2 = new int[4, 4]
// {{1, 5, 8, 5},
// {4, 9, 4, 2},
// {7, 2, 2, 6},
// {2, 3, 4, 7}};
WriteLine("Исходная матрица 2");
PrintMatrix(matrix2);

if (Validate(matrix1, matrix2))
{
    int[,] resultMatrix = MultiplyMatrix(matrix1, matrix2);
    WriteLine("Результат умножения");
    PrintMatrix(resultMatrix);
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int dimension = matrix1.GetUpperBound(1) + 1;
    int rows1 = matrix1.GetUpperBound(0) + 1;
    int columns2 = matrix2.GetUpperBound(1) + 1;
    int[,] resultMultiply = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int r = 0; r < dimension; r++)
            {
                resultMultiply[i, j] += matrix1[i, r] * matrix2[r, j];
            }
        }
    }
    return resultMultiply;
}

bool Validate(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetUpperBound(1) == matrix2.GetUpperBound(0))
    {
        return true;
    }
    WriteLine("Число столбцов первой матрицы должно быть равно числу строк второй матрицы");
    return false;
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
