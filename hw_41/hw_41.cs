using System;
using static System.Console;

Clear();
int count = Prompt("Введите количество чисел");
int countPositive = 0;
int number;
for (int i = 0; i < count; i++)
{
    number = int.Parse(ReadLine());
    if (number > 0)
        countPositive++;
}
WriteLine($"Количество положительных = {countPositive}");

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
