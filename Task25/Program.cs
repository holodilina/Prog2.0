// Цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

Console.WriteLine("Введите два числа: ");
Console.Write("Введите первое число: ");
var a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
var b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(power(a, b));

static int power(int a, int b)
{ 
    var res = 1; 

    if(b==0)
        return res;

    for (var i=1; i<=b; i++)
    {
        res *= a;
    } 
    return res;   
}
