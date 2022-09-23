// ===============================================================================================
// #0 Программа, которая принимает на вход число и выдаёт его квадрат (число умноженное на само себя)

string? inputLine = Console.ReadLine();
// мы понимаем, что может быть null, поэтому ставим после string знак ?
// далее делаем проверку на null
if (inputLine != null);
{
    int inputNumber = int.Parse(inputLine); // этот оператор превращает строку в число
    int outNumber = inputNumber * inputNumber; 
    // можно записать как: int outNumber = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outNumber);
}

// второй вариант с null проверкой, более короткий:
// string inputLine = Console.ReadLine()??"";
