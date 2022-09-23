// Программа, которая выводит будний или выходной день недели.

Console.Write("Введите число: ");

while(true)
{
    string? input = Console.ReadLine(); 
    int dayOfWeek;
    if(!string.IsNullOrWhiteSpace(input)&&input.Equals("exit"))
      break;

    if(string.IsNullOrWhiteSpace(input)
    ||!int.TryParse(input, out dayOfWeek)
    ||dayOfWeek<1
    ||dayOfWeek>7)
    {
        Console.WriteLine("Введите день недели от 1 до 7");
        continue;
    }

    Console.WriteLine(dayOfWeek==6||dayOfWeek==7?"Выходной":"Будний"); 
 
}
