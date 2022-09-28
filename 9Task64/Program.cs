// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число N: ");
int N = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Натуральные числа от N до 1: ");

if (1 > N)
for (int i = N; i <= 1; i++)
    Console.Write($" {i}");
else
    for (int i = 1; i <= N; i++)
        Console.Write($" {i}");

Console.WriteLine();