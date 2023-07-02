using static System.Console;
using System;

Clear();
Write("Введите число ");
int a = int.Parse(ReadLine());

while (a > 1000)
{
    a = a/10;
}

if (a < 100)
{
    WriteLine("Третьей цифры нет");
}
else
{
    WriteLine($"Третья цифра {a % 10}");
}
