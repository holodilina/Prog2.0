/// №20.1 Вариант 2. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D-пространстве

int ReadData(string line) 
{    
    Console.WriteLine(line); 
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number;
}

// Расстояние между двумя точками
double CalculateDistance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}
    int x1 = ReadData("Введите координату X первой точки: ");
    int x2 = ReadData("Введите координату Y первой точки: ");
    int y1 = ReadData("Введите координату X второй точки: ");
    int y2 = ReadData("Введите координату Y второй точки: ");

void PrintResult(string line)
{
    Console.WriteLine(line);
}

double result = CalculateDistance(x1, y1, x2, y2);
PrintResult("Расстояние между двумя точками: " + Math.Round(result, 2));
