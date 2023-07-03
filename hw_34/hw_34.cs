using System;
using static System.Console;

Clear();
int size = Prompt("Введите размер массива");
int[] array = NewArray(size);
PrintArray(array);
WriteLine($"Количество четных = {CountEven(array)}");

void PrintArray(int[] array) 
{
    foreach (var item in array)
    {
        Write($"{item} ");
    }
    WriteLine();
}

int CountEven(int[] array) 
{
    int count = 0;
    foreach(var item in array) {
        if (item%2 == 0)
            count++;
    }
    return count;
}

int[] NewArray(int size) 
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++) 
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}