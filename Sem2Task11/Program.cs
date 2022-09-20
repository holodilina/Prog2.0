// Ввести трёхзначное число и удалить у него вторую цифру,
// вывести пользователю число, которое содержит первую и третью цифру.

Console.WriteLine(number);

int firstDigit = number / 100;
int thirdDigit = number % 10;

//Вариант Евгения
void Variant2()
{
System.Random numberGeneration = new System.Random();
int number = numberGeneration.Next(100, 1000);
Console.WriteLine(number);
int firstDigit = number  / 100;
int thirdDigit = number % 10;
Console.WriteLine(firstDigit*10+thirdDigit);
}

// Вариант Константина
void Variant1()
{
    Console.WriteLine("Вариант 1: ");

    int number = new Random().Next(100, 1000);

    Console.WriteLine(number);
    char[] charArray = number.ToString().ToCharArray();
    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}

// Вариант Михаила




Variant2();
Variant1();
