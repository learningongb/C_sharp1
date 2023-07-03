using System;
using static System.Console;

Clear();
int digit = prompt("Введите число");
WriteLine($"Сумма цифр числа {sumDigits(digit)}");

int sumDigits(int value)
{
    int result = 0;
    while (digit > 0)
    {
        result += digit % 10;
        digit /= 10;
    }
    return result;
}

int prompt(String text)
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine());
}