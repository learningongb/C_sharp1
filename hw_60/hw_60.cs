using System;
using static System.Console;

Clear();

const int dimension1 = 2;
const int dimension2 = 2;
const int dimension3 = 2;
const int minValue = 10;
const int maxValue = 99;

int[,,] array = GenerateArray();
PrintArray(array);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < dimension1; i++)
    {
        for (int j = 0; j < dimension2; j++)
        {
            for (int k = 0; k < dimension3; k++)
            {
                Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            WriteLine();
        }
    }
}

int[,,] GenerateArray()
{
    int[,,] array = new int[dimension1, dimension2, dimension3];
    int[] usedNumbers = new int[dimension1 * dimension2 * dimension3];
    Random random = new Random();
    for (int i = 0; i < dimension1; i++)
    {
        for (int j = 0; j < dimension2; j++)
        {
            for (int k = 0; k < dimension3; k++)
            {
                int candidate = random.Next(minValue, maxValue + 1);
                while (inArray(usedNumbers, candidate))
                {
                    candidate = random.Next(minValue, maxValue + 1);
                }
                array[i, j, k] = candidate;
                usedNumbers[i + j + k] = candidate;
            }
        }
    }
    return array;
}

bool inArray(int[] array, int value)
{
    foreach (var item in array)
    {
        if (item == value)
            return true;
    }
    return false;
}
