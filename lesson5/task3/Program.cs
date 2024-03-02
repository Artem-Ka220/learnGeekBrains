// // Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] array = new int[5,4];
double[] array2 = new double[array.GetLength(0)];

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
            if (j == 0){
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

void GetSumInArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum=0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+= array[i,j];
        }
        array2[i]= sum / array.GetLength(1);
    }
}

void PrintArray2()
{
    for (int i = 0; i < array2.Length; i++)
    {
        if(i == 0){
            System.Console.Write($"[ {array2[i],2}, ");
        }else if(i < array2.Length - 1){
            System.Console.Write($"{array2[i]}, ");
        }else{
            System.Console.Write($"{array2[i]} ]");
        }   
    }
}

FillingArray();
PrintArray();

GetSumInArray();
System.Console.WriteLine();
PrintArray2();
