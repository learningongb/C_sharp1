using System;
using static System.Console;

Clear();

int m = Prompt("Введите M");
int n = Prompt("Введите N");

if (Validate(m, n))
{
    WriteLine(AccermanFunction(m, n));
}

int AccermanFunction(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0)
    {
        return AccermanFunction(a - 1, 1);
    }
    else
    {
        return AccermanFunction(a - 1, AccermanFunction(a, b - 1));
    }
}

bool Validate(int m, int n)
{
    if (m > 3 || n > 5)
    {
        WriteLine("Не стоит задавать значения m > 3 и n > 5");
        return false;
    }
    return true;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
