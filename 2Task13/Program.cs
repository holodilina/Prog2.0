// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

while(true)
{
    string? input = Console.ReadLine(); 
    int r;
    if(!string.IsNullOrWhiteSpace(input)&&input.Equals("exit"))
      break;

      if(string.IsNullOrWhiteSpace(input)
      ||input.Length<3
      ||!int.TryParse(input, out r))
      {
         Console.WriteLine(" -> нет третьей цифры");
      }
      else 
      {
       Console.WriteLine($"Третья цифра числа {input} -> {input[2]}"); 
      }
}
