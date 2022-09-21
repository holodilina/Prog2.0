// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23

/* // №1 Вариант Евгения
Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if(inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
{
    Console.Write("Число кратно одновременно 7 и 23");
}
else
{
    Console.Write("Число НЕ кратно одновременно 7 и 23");
} */


/* // №2 Вариант Михаила
int number, resultA, resultB;

//запрашивает число у пользователя, принимает текст запроса и команду выход
int RequestNumber(string text = "Введите число: ", string exitCmd = "q")
{
    while(true) //цикл выполняется до введения целого числа или "q"
    {
        Console.Write(text + ": ");
        string? inputLine = Console.ReadLine();

        // игнорируем пустое нажатие
        if (inputLine == null)
        {
            continue;
        }
        // выходим из программы
        if (inputLine.ToLower() == exitCmd)
        {
            Environment.Exit(0);
        }
        // выдаем полученное число
        if (int.TryParse(inputLine, out int number))
        {
            return number;
        }
    }
}

// чтение данных из консоли
void ReadData()
{
    number = RequestNumber("Введите число: ");
}

// определяем кратность числа
void CalculateData()
{
    resultA = number % 7;
    resultB = number % 23;
}

// вывод данных
void PrintData()
{
if (resultA == 0 && resultB == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}
}

ReadData();
CalculateData();
PrintData(); */


// №3 Вариант Анатолия
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) 
    ? ("Кратно") : ("Не кратно"));
}