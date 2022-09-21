// №12 Программа, которая на вход принимает два числа и выводит: 
// является ли второе число кратным первому
// если второе число некратно первому, то программа выводит остаток от деления

ReadData();
ConculateDate();
PrintData();

// объявим глобальные переменные на все методы, чтобы они были видны
int inputNumberA = 0;
int inputNumberB = 0;

// вводим переменную результата
bool result = false;

// Получаем два числа от пользователя
void ReadData();
{
   Console.WriteLine("Введите первое число: ");
   string? inputLineA = Console.ReadLine();
   Console.WriteLine("Введите второе число: ");
   string? inputLineB = Console.ReadLine();

   inputNumberA = int.Parse(inputLineA);
   inputNumberB = int.Parse(inputLineB);
}

// Определяем кратность чисел
void ConculateDate(); // вычисление
{
result = (inputNumberB % inputNumberA == 0);
}

// Выводим данные программы вычисления
void PrintData(); // вывод данных
{
if (result)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Остаток от деления: "  + inputNumberB % inputNumberA);
}
}



/* // Вариант Константина
void Variant1();
{
Console.WriteLine("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? inputLineB = Console.ReadLine();

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);


Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));

}


// Вариант Евгения
void Variant2();
{
    string? inputLineA = Console.ReadLine();
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = (int)int.Parse(inputLineA);
        int inputNuberB = (int)int.Parse(inputLineB);

        Console.WriteLine(inputNuberB % inputNumberA == 0 ? "Является кратным" : inputNuberB % inputNumberA);
    }
} */

