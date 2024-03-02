// // Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

int[,] array = new int[5,4];

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0){
                System.Console.Write("[");
            }
            if(j < array.GetLength(1) - 1){
                System.Console.Write($"{array[i,j],2},");
            }else
            {
                System.Console.Write($"{array[i,j],2} ]");
            }   
        }
        System.Console.WriteLine();
    }
}

int GetSumInArray()
{
    int sum=0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j)
            {
                sum+= array[i,j]; 
                // sum = sum+ array[i,j];
            }
        }
    }
    return sum;
}

FillingArray();
PrintArray();

System.Console.WriteLine(GetSumInArray());
