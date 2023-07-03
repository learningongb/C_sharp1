using System;
using static System.Console;

Clear();
int size = Prompt("Введите размер массива");
int[] array = NewArray(size);
PrintArray(array);
WriteLine($"Разница между максимальным и минимальным элементами = {Max(array) - Min(array)}");

int Min(int[] array) 
{
    int min = array[0];
    foreach (var item in array)
    {
        if (item < min) min = item;
    }
    return min;
}
int Max(int[] array) 
{
    int max = array[0];
    foreach (var item in array)
    {
        if (item > max) max = item;
    }
    return max;
}

void PrintArray(int[] array) 
{
    foreach (var item in array)
    {
        Write($"{item} ");
    }
    WriteLine();
}

int[] NewArray(int size) 
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++) 
    {
        array[i] = random.Next(100);
    }
    return array;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
