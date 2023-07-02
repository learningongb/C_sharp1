Console.Clear();
Console.Write("Введите число 1 ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 3 ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;

Console.WriteLine(max);