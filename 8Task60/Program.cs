// Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
var mass = InputMass();

if(mass==null)
{
    Console.WriteLine("Неверный ввод");
    return;
} 

PrintMass(mass);

int[,,]? InputMass()
{
    Console.Write("Введите размер трехмерного массива через запятую N,M,K:  ");
    
    var sizeInput = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(sizeInput)) 
        return null; 

    var sizeArray = sizeInput.Split(',');
    if(sizeArray.Length!=3)
        return null; 

    int n=0, m=0, k=0;
    if(!int.TryParse(sizeArray[0].Trim(), out n))
        return null; 

    if(!int.TryParse(sizeArray[1].Trim(), out m))
        return null; 

    if(!int.TryParse(sizeArray[1].Trim(), out k))
        return null;

    var res = new int[n, m, k]; 

    var hash = new HashSet<int>();

    for(int i=0;i<res.GetLength(0);i++)
    {
        for(int i2=0;i2<res.GetLength(1);i2++)
        {
            for(int i3=0;i3<res.GetLength(2);i3++)
            {
               var rand = new Random();   
               while(true)
               {
                    var d = rand.Next(10,100);
                    if(!hash.Contains(d))
                    {
                        res[i, i2, i3] = d;
                        hash.Add(d);
                        break;
                    }
                    Console.Write($"{d}, ");
               }
               Console.WriteLine();
            }            
        }       
    }

    return res;
}  

void PrintMass(int[,,] mass)
{
    Console.WriteLine("Результат: ");
    Console.WriteLine();
    for(int i=0; i<mass.GetLength(0);i++)
    {
        for(int i2=0; i2<mass.GetLength(1);i2++)
        {
            for(int i3=0; i3<mass.GetLength(2);i3++)
            {            
                Console.Write($"{mass[i, i2, i3]} ({i},{i2},{i3})\t");
            }
            Console.WriteLine();  
        }                   
    }
}

Console.WriteLine();