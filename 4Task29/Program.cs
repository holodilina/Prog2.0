// Программа, которая задает массив из 8-ми элементов и выводит их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    
     int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
           position = index;
           break;
        }
        index++;
    }
    return position;
}

int[] array = new int[8];

FillArray(array);

array[0] = 1;
array[1] = 2;
array[2] = 5;
array[3] = 7;
array[4] = 19;
array[5] = 6;
array[6] = 1;
array[7] = 33;

PrintArray(array);
