using System;
using static System.Console;

Clear();
int digit = Prompt("Введите число");
int power = Prompt("Введите степень");
WriteLine($"Результат возведения в степень {Pow(digit, power)}");

int Pow(int digit, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= digit;
    }
    return result;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}