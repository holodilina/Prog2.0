// Вид 1 (ничего не возвращает, ничего не примнимает)
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2 (ничего не возвращает)
void Method2(string msg)
{
   Console.WriteLine(msg);
}
Method2("Текст сообщения ...");

// метод 2.1.
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// неименованные аргументы (обязательно по-порядку)
// Method21("Текст ...", 4);

//именованные аргументы (не обязательно по-порядку)
Method21(msg: "Текст ...", count: 4);
Method21(count: 4, msg: "Новый текст ...");

// Вид 3 (что-то возвращают, ничего не принимают)
// обязательно указать тип данных, значение которого мы ожидаем
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 (группа методов, которые что-то принимают и что-то возвращают)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

/// Вид 4.1 метод с for (группа методов, которые что-то принимают и что-то возвращают)
string Method41(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++);
    {
        result = result + text;
    }
    return result;
}
string re = Method41(10, "asdf");
Console.WriteLine(re);


// Вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}
