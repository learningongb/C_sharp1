using static System.Console;
using System;

bool FindInArray(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
            return true;
    }
    return false;
}

Clear();
Write("Введите номер дня недели ");
int a = int.Parse(ReadLine());

int[] week = new int[7] {1,2,3,4,5,6,7};
int[] weekend = new int[2] {6, 7};

if (FindInArray(weekend, a))
    WriteLine("Выходной");
else if (FindInArray(week, a))
    WriteLine("Будний");
else
    WriteLine("Нет такого дня недели");
