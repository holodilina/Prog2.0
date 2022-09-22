// №16 Напишите программу, которая принимает на вход два числа
// и проверяет является одно число квадратом другого числа

int ReadData(string line) // делает метод универсальным, эту часть кода можно использовать везде
{
    // выводим сообщение
    Console.WriteLine(line); 
    
    // считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    // "хвостик" ?? "" - означает, что если пользователь ничего не введет - это пустое число 0

    // возвращаем значение
    return number; // метод должен возвращать
}

// Тест на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int firstNum, int secondNum)
{
if (SqrTest(firstNum, secondNum))
{
    Console.WriteLine("Число " + firstNum + " квадрат числа " + secondNum);
}
else
{
    Console.WriteLine("Число " + firstNum + " НЕ квадрат числа " + secondNum);
}
}

int num1 = ReadData("Введите первое число: ");
int num2 = ReadData("Введите второе число: ");

PrintData(num1, num2);
PrintData(num2, num1);