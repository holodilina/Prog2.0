// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("ЗАДАЙТЕ ЧИСЛО: ");

var input = Console.ReadLine();
int num;
if(string.IsNullOrWhiteSpace(input) 
||!int.TryParse(input, out num))
{
    Console.WriteLine("Ошибка ввода");
    return;
}

for(var i=1;i<=num;i++)
{
    var pow = Math.Pow(i,3);
    Console.WriteLine($"{pow}");   
} 