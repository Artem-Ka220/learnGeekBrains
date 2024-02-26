// №1
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// тип возв.значения /void + Название+ ()+ {}
// Название+()

System.Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];

CompletionArray();
PrintArray();
Console.WriteLine(FindCountNumber());

void CompletionArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(20,25);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    if(i == 0){
        System.Console.Write($"[ {array[i]}, ");
    }else if(i < array.Length-1){
        System.Console.Write($"{array[i]}, ");
    }else{
        System.Console.Write($"{array[i]} ]");
    }
    System.Console.WriteLine();
}

int FindCountNumber()
{
    int count=0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 10==1 && array[i]%7==0)
        {
            count= count+1;
            // count++;
        }
    }
    return count;
}