// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("\n\n");

double x1 = 7;
double y1 = -5;
double z1 = 0;

double x2 = 1;
double y2 = -1;
double z2 = 9;
  
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние равно: {d}");

Console.Write("\n\n");