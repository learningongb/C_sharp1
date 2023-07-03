using System;
using static System.Console;

Clear();
Write("Введите число ");
int digit = int.Parse(ReadLine());

int result = 0;

while (digit > 0) 
{
    result += digit % 10;
    digit /= 10;
}

WriteLine($"Сумма цифр числа {result}");