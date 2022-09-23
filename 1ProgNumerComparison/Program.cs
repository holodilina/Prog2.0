// Программа, которая на вход принимает два числе и выдает, какое число больше, а какое меньше.

{
    Console.WriteLine("Введите два числа: ");
    int a, b;
    Console.Write("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());

    bool Chto0 = a > b;
    bool Chto1 = a == b;
    bool Chto2 = a < b;

    if (Chto0)
    {
        Console.WriteLine($"Число {a} больше, чем {b}");
    }
    else if (Chto1)
    {
        Console.WriteLine($"Число {a} и {b} равны");
    }
    else
    {
        Console.WriteLine($"Число {b} больше, чем {a}");
    }
}
