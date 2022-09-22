// №20 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D-пространстве

int ReadData(string line) 
{    
    Console.WriteLine(line); 
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number;
}

// Расстояние между двумя точками
double CalcData(int x1, int y1, int x2, int y2)
{
    double res = 0;
    res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return res;
}

    int x1 = ReadData("Введите x1 ");
    int x2 = ReadData("Введите x2 ");
    int y1 = ReadData("Введите y1 ");
    int y2 = ReadData("Введите y2 ");

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// PrintResult(CalcData(x1, y1, x2, y2).ToString());
// Math.Round(); // округление значения

// округление значения до какой-то цифры до запятой, например, до 2-й
PrintResult(Math.Round(CalcData(x1, y1, x2, y2), 2).ToString());
