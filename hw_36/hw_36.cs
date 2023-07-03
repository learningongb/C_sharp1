using System;
using static System.Console;

Clear();
int size = Prompt("Введите размер массива");
int[] array = NewArray(size);
PrintArray(array);
WriteLine($"Сумма элементов на нечетных позициях (нумерация с 0) = {SumOdd(array)}");

int SumOdd(int[] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (i%2 != 0)
            sum += array[i];
    }
    return sum;
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
        array[i] = random.Next(-100, 101);
    }
    return array;
}

int Prompt(String text)
{
    Write($"{text} ");
    return int.Parse(ReadLine());
}
