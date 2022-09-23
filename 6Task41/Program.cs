// Пользователь вводит с клавиатуры М чисел.
// Посчитать сколько чисел больше 0 ввел пользователь.

Console.Write(":");

string? input = Console.ReadLine();

if(string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("sdfds");
    return;
} 
var res = Count(input.Split(","));
//var res = Count("0,7,8,-2,-2".Split(","));
//var res = Count("1,-7,567,89,223".Split(","));
Console.WriteLine($"результат {res}");

int Count(string[] numbers)
{
    int res=0;
    foreach(var n in numbers)
    {
        int p=0;
        //Console.WriteLine(n.Trim());
        if(int.TryParse(n.Trim(), out p)&&p>0)
        {
            res++;
        }
    }
    return res;
}




