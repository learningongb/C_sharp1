using System;
using static System.Console;

Clear();
float b1 = Prompt("Введите b1");
float k1 = Prompt("Введите k1");
float b2 = Prompt("Введите b2");
float k2 = Prompt("Введите k2");

float x = (b2 - b1) / (k1 - k2);
float y = k1 * x - b1;

WriteLine(b2 - b1);
WriteLine(k1 - k2);
WriteLine((b2 - b1) / (k1 - k2));

WriteLine($"Прямые пересекаются в точке Х={x}, Y={y}");

float Prompt(String text)
{
    Write($"{text} ");
    return float.Parse(ReadLine());
}
