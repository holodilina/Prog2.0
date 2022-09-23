// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;
{

    {
        int num, r, sum=0, t;

        Console.Write("\n\n");
        Console.Write("ВВЕДИТЕ ПЯТИЗНАЧНОЕ ЧИСЛО: ");
        num = Convert.ToInt32(Console.ReadLine());
        for(t=num;num!=0;num=num/10)
        {
            r=num % 10;
            sum=sum*10+r;
        }
        if(t==sum)
            Console.Write("{0} -> это палиндром",t);
        else
            Console.Write("{0} -> это не палиндром",t);
        
       
    }
     Console.Write("\n\n");
}
