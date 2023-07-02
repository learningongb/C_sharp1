using static System.Console;
using System;

int TrimTo100(int value)
{
    while (value > 1000)
    {
        value = value/10;
    }
    return value;
}

Clear();
Write("Введите число ");
int a = int.Parse(ReadLine());

if (a < 100)
{
    WriteLine("Третьей цифры нет");
}
else
{
    WriteLine($"Третья цифра {TrimTo100(a) % 10}");
}
