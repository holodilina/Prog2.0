// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой элементов.

var mass = InputMass();

if(mass==null)
{
    Console.WriteLine("Неверный ввод");
    return;
}

var l =  FindLine(mass);
Console.WriteLine($"Номер строки с наименьшей суммой элементов:{l}");

int[,]? InputMass()
{
    Console.Write("Введите размер матрицы:");
    
    var sizeInput = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(sizeInput)) 
        return null; 

    int n=0;
    if(!int.TryParse(sizeInput, out n))
        return null;  

    var res = new int[n, n]; 
    Console.WriteLine($"Ввведите {n} строк, числа в строчках через запятую");
    for(var i=0;i<n;i++)
    {
        var lineInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(lineInput)) 
            return null;        
        var lineArry = lineInput.Split(',');
        if(lineArry.Length!=n)
            return null;
        for(var i2=0;i2<n;i2++) 
        {
            int a;
            if(!int.TryParse(lineArry[i2].Trim(), out a))
                return null;       
            res[i,i2]=a;  
        }
    }
    return res;
}  

int FindLine(int[,] mass)
{ 
    int line=0;
    var sumLine = new int[mass.GetLength(0)];
    for(int i=0; i<mass.GetLength(0);i++)
    { 
        for(int i2=0; i2<mass.GetLength(1);i2++)
        {   
            sumLine[i]+=mass[i,i2];
        }
        
        if(sumLine[i]<sumLine[line])
            line = i;       
    }
    return line+1;
}

