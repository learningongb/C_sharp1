Console.Clear();
Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
int i = 1;
while (i <= a)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}

