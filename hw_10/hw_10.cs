using static System.Console;
using System;

Clear();
Write("Введите трехзначное число ");
int a = int.Parse(ReadLine());

int result = a % 100 / 10;
WriteLine($"{a} -> {result}");
