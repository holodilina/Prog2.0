// №22.1 Вариант 2. Напишите программу, которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N

int ReadData(string line) 
{    
    Console.WriteLine(line); 
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number;
}

// Метод, который собирает верхушку таблицы
string LineNumbers(int numberN)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i + "\t"; //использовать табуляцию /t , чтобы выровнять как таблицу
        ++i;
    }
    outLine = outLine + numberN;
    return outLine;
}

// Метод, который собирает низ таблицы
string LineSqr(int numberN)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i * i + "\t";
        ++i;
    }
    outLine = outLine + numberN * numberN;
    return outLine;
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");
string lineTop = LineNumbers(num);
string lineDown = LineSqr(num);

PrintResult(lineTop);
PrintResult(lineDown);