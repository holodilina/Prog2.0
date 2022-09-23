// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("ВВЕДИТЕ ПЯТИЗНАЧНОЕ ЧИСЛО: ");

var input = Console.ReadLine();
int num;
if(string.IsNullOrWhiteSpace(input)
||input.Length!=5
||!int.TryParse(input, out num))
{
    Console.WriteLine("Ошибка ввода");
    return;
}

var inverse=string.Empty;

for(var i = input.Length-1; i>=0; i--)
{
    inverse+=input[i];
}    

if (string.Compare(inverse, input) == 0)
{
    Console.WriteLine(" -> палиндромом");
}
else{
        Console.WriteLine(" -> НЕ палиндромом");      
}



