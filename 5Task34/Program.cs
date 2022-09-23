// Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

var maxSize= 10000;

Console.Write($"Введите размер массива от 1 до {maxSize}: ");
string? sizeArrayStr = Console.ReadLine(); 

if (string.IsNullOrWhiteSpace(sizeArrayStr)||
    !int.TryParse(sizeArrayStr, out var sizeArray)
    || sizeArray<1
    || sizeArray>maxSize)
{
    Console.WriteLine("не верный ввод");
    return;
} 

var count=0;
foreach(var a in CreateRandomArray(sizeArray))
{
        if(a%2==0)
            count++;
}

Console.WriteLine($"Количество четных чисел: {count}"); 

static int [] CreateRandomArray(int size)
{
    var array = new int[size];
    var rn = new Random();
    for(var i=0; i < size; i++)
    {
        array[i]=rn.Next(100, 1000);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    return array;
}