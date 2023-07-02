using static System.Console;
using System;

int[] InputData()
{
    int[] result = new int[3];
    WriteLine("Введите координаты точки");
    Write("X ");
    result[0] = int.Parse(ReadLine());
    Write("Y ");
    result[1] = int.Parse(ReadLine());
    Write("Z ");
    result[2] = int.Parse(ReadLine());
    return result;
}

double Distance(int[] p1, int[] p2)
{
    return Math.Round(Math.Abs(Math.Sqrt(Math.Pow(p1[0] - p2[0], 2)
        + Math.Pow(p1[1] - p2[1], 2)
        + Math.Pow(p1[2] - p2[2], 2))), 2);
}

Clear();

int[] point1 = InputData();
int[] point2 = InputData();

WriteLine($"Расстояние между точками {Distance(point1, point2)}");
