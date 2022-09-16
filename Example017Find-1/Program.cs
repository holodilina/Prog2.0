// Продолжение Example016Find-1
// Улучшение программы: вывести только одно число
// технически здесь понадобится другой оператор break
// таким образом будет находиться только первый элемент

int[] array = { 1, 18, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    // index = index +1;
    index++;
}

// переписать код с использованием генератора случайных чисел:
// см. Example018Find-2