using System;
using static System.Console;

Console.Clear();

const int countRows = 5;
const int countColumns = 4;

int[,] matrix = GenerateMatrix(countRows, countColumns);
PrintMatrix(matrix);

int[,] GenerateMatrix(int countRows, int countColumns)
{
    int[,] matrix = new int[countRows, countColumns];
    int i = 0;
    int j = 0;
    int counter = 1;
    int modificatorI = 0;
    int modificatorJ = 1;
    int maxI = countRows;
    int maxJ = countColumns;
    int minI = -1;
    int minJ = -1;
    bool moveHorizontal = true;
    while (true)
    {
        matrix[i, j] = counter;
        counter++;
        i += modificatorI;
        j += modificatorJ;
        if (moveHorizontal)
        {
            if (j == maxJ || j == minJ)
            {
                if (j == maxJ)
                {
                    modificatorI = 1;
                    minI++;
                }
                else
                {
                    modificatorI = -1;
                    maxI--;
                }
                j -= modificatorJ;
                modificatorJ = 0;
                moveHorizontal = false;
                if (maxI - minI == 1)
                    break;
                i += modificatorI;
            }
        }
        else
        {
            if (i == maxI || i == minI)
            {
                if (i == maxI)
                {
                    modificatorJ = -1;
                    maxJ--;
                }
                else
                if (i == minI)
                {
                    modificatorJ = 1;
                    minJ++;
                }
                j += modificatorJ;
                i -= modificatorI;
                modificatorI = 0;
                if (maxJ - minJ == 1)
                    break;
                moveHorizontal = true;
            }
        }
    };
    return matrix;
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
