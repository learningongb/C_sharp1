Console.Clear();
Console.Write("Введите число. Проверим его четность. ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
