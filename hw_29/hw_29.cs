
Console.Clear();
int count = prompt("Введите число");
int max = prompt("Введите максимальное число");
int min = prompt("Введите минимальное число");
printArray(getArray(count, min, max));

void printArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] getArray(int count, int min, int max) 
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++) 
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int prompt(String text)
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine());
}