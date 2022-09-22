// №17 Определить номер четверти плоскости, в которой находится точка

// Универсальный метод общения с пользователем
int ReadData(string line) 
{    
    Console.WriteLine(line); 
    
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    // "хвостик" ?? "" - означает, что если пользователь ничего не введет - это пустое число 0

    // возвращаем значение
    return number; // метод должен возвращать
}

// Метод, который считает четверти
int QuterTest(int x, int y)
{
     /* if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] > 0);
    return 1;
    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] > 0);
    return 2;
    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] < 0);
    return 3;
    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] < 0);
    return 4; */   // не верная конструкция

    if (x > 0 && y > 0)
    return 1;
    if (x < 0 && y > 0)
    return 2;
    if (x < 0 && y < 0)
    return 3;
    if (x > 0 && y < 0)
    return 4;

    return -1;
}

// Универсальный метод печати (т.е. вывода) результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

int res = QuterTest(x, y);

PrintResult("Точка находится в четверти № " + res);