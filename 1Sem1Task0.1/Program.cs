// продолжение Task0
// проверка времени выполнения действия программы

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = 0;

    DateTime d1 = DateTime.Now;
    for (int i = 0; i < 10000000; i++)
    {
        outNumber = inputNumber * inputNumber;
    }

    DateTime d2 = DateTime.Now;
    Console.WriteLine(d2 - d1);
    
    Console.WriteLine(outNumber);
}
