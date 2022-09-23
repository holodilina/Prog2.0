// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

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

var res=CalRes(CreateRandomArray(sizeArray)); 
//var res = CalRes( new double[] {3, 7, 22, 2, 78});

Console.WriteLine($"Результат: {res}"); 

static double [] CreateRandomArray(int size)
{
    var array = new double[size];
    var rn = new Random();
    for(var i=0; i < size; i++)
    {
        array[i]=rn.NextDouble();
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    return array;
}

// Найдите разницу между максимальным и минимальным элементами массива.
static double CalRes(double[] array)
{ 
    double min=array[0];
    double max=array[0];

    for(var i=1;i<array.Length;i++)
    {
        if(array[i]<min)
        {
            min = array[i];
        }

        if(array[i]>max)
        {
            max=array[i];
        }
    }

    return max - min;
}

