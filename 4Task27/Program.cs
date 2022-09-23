// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
int n = (int)Math.Log10(num) + 1;
Console.WriteLine("Количество чисел в числе: " + n);

   int summ = 0;
   while ( num !=0)
   {
    summ += num % 10;
    num /= 10;
   }

   
Console.WriteLine("Сумма чисел: " +summ);



