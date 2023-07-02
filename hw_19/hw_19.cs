using static System.Console;
using System;

int InputData()
{
    Write("Введите пятизначное число ");
    return(int.Parse(ReadLine()));
}

bool ValidateInput(int value)
{
    if (value < 10000 && value > 99999)
    {
        WriteLine("Это не пятизначное число. Нужно ввести именно пятизначное число");
        return false;
    }
    return true;
}

bool isPolindrom(int value)
{
    return (value / 10000 == value % 10) && (value % 10000 / 1000 == value % 100 / 10);
}

Clear();
int number = InputData();
if (ValidateInput(number))
    if (isPolindrom(number))
        WriteLine("Это полиндром");
    else
        WriteLine("Это не полиндром");

