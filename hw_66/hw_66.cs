using System;
using static System.Console;

Clear();

int m = Prompt("Введите M");
int n = Prompt("Введите N");
WriteLine(SumNatural(m, n));

int SumNatural(int min, int max)
{
    int sum = 0;
    for (int i = 0; i < max - min + 1; i++)
    {
        sum += i + min;
    }
    return sum;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
