// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");

    while (true)

        {
            string input = Console.ReadLine();
            if (!input.Equals("exit"))
                    Console.WriteLine("Вторая цифра числа {0} -> {1}", input, input[1]);

            else
                    break;
        }
        
    
