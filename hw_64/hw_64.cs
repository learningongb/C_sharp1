using System;
using static System.Console;

Clear();

int m = Prompt("Введите M");
int n = Prompt("Введите N");
int[] array = GetNatural(m, n);
WriteLine(String.Join(", ", array));

int[] GetNatural(int min, int max)
{
    int count = max - min + 1;
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = i + min;
    }
    return result;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
