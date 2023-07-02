using static System.Console;
using System;

int InputData()
{
    Write("Введите число ");
    return(int.Parse(ReadLine()));
}

int Cube(int value)
{
    return value * value * value;
}

Clear();
int number = InputData();
for (int i = 1; i <= number; i++)
{
    Write($"{Cube(i)} ");
}