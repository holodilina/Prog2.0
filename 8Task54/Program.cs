// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

var mass = InputMass();

if(mass==null)
{
    Console.WriteLine("Неверный ввод");
    return;
}

SortMass(mass);
PrintMass(mass);

int[,]? InputMass()
{
    Console.Write("Введите размер двухмерного массива N,M:");
    
    var sizeInput = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(sizeInput)) 
        return null; 

    var sizeArry = sizeInput.Split(',');
    if(sizeArry.Length!=2)
        return null; 

    int n=0, m=0;
    if(!int.TryParse(sizeArry[0].Trim(), out n))
        return null; 

    if(!int.TryParse(sizeArry[1].Trim(), out m))
        return null; 

    var res = new int[n,m]; 
    Console.WriteLine($"Ввведите {n} строк, числа в строчках через запятую");
    for(var i=0;i<n;i++)
    {
        var lineInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(lineInput)) 
            return null;        
        var lineArry = lineInput.Split(',');
        if(lineArry.Length!=m)
            return null;
        for(var i2=0;i2<m;i2++) 
        {
            int a;
            if(!int.TryParse(lineArry[i2].Trim(), out a))
                return null;       
            res[i,i2]=a;  
        }
    }
    return res;
}  

void SortMass(int[,] mass)
{ 
    for(int i=0; i<mass.GetLength(0);i++)
    {
        for(int i2=mass.GetLength(1); i2>1;i2--)
        {
          for(int i3=0; i3<i2-1;i3++)
          {
             if(mass[i, i3]<mass[i, i3+1]) 
             {
                var next=mass[i, i3+1];
                mass[i, i3+1]=mass[i, i3];
                mass[i, i3]=next;
             }      
          }          
        }     
    } 
}

void PrintMass(int[,] mass)
{
    Console.WriteLine("Результат");
    for(int i=0; i<mass.GetLength(0);i++)
    {
        for(int i2=0; i2<mass.GetLength(1);i2++)
        {
            Console.Write($"{mass[i, i2]}\t");
        }  
        Console.WriteLine();             
    }
}