using System;
using static System.Console;

Clear();
Write("Введите число ");
int digit = int.Parse(ReadLine());
Write("Введите степень ");
int power = int.Parse(ReadLine());

int result = 1;
for (int i = 0; i < power; i++) 
{
    result *= digit;
}

WriteLine($"Результат возведения в степень {result}");