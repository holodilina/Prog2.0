// переписать код с использованием генератора случайных чисел
// и с использованием методов
// метод, который выводит все элементы по-порядку
// это метод заполнения массива и печати его на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // положить новое случайное число Random из диапазона Next

        // index = index +1;
        index++;
    }
}
// заполнить случайными числами - это void

//метод, который будет печатать
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];
// new int[10] - обозначает "создай массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);

// адаптировать метод см. Example019Find-3