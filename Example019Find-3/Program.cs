// адаптировать метод из Example018Find-2

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

// далее начало адаптации
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // int position = 0;
    // исправить ошибку вывода отсутстующего числа в массиве как 0 - сделать минусовое число
    // например -1, что можно интерпретировать "такой элемент не найден"
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
           position = index;

           // чтобы получить в выводе первое вхождение - добавляем break
           break;
        }
        index++;
    }
    return position;
}

// конец адаптации

int[] array = new int[10];
// new int[10] - обозначает "создай массив, в котором будет 10 элементов

FillArray(array);

//если нужно добавить в случайный список искусственно числа, то:
array[4] = 4;
array[6] = 4;
// добавили на четвертую позицию и на шестую

PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);