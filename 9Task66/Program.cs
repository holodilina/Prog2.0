// Задайте значения M и N.
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

// выводит все числа от M до N
Console.WriteLine();
Console.Write("Введите значение M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Натуральные числа от N до M:");
int sum = 0;
for (int i = M; i <= N; i++)
{
    Console.Write($" {i}"); 
    sum+=i;
}
Console.WriteLine();

// находит сумму всех значений от M до N
Console.WriteLine($"Сумма натуральных элементов в промежутк от M до N: {sum}");
Console.WriteLine();