// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

var summ=0;
var array = CreateRandomArray(sizeArray);

for(var i=0; i<sizeArray;i++)
{
        if(i%2!=0)
            summ+=array[i];
}

Console.WriteLine($"Сумма: {summ}"); 

static int [] CreateRandomArray(int size)
{
    var array = new int[size];
    var rn = new Random();
    for(var i=0; i < size; i++)
    {
        array[i]=rn.Next(-10, 11);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    return array;
}
