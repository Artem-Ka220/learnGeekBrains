// // Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

int[] array = new int [10];

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string isFind= "Нет";

for (int i = 0; i < array.Length ; i++)
{
    array[i]= new Random().Next(1,6);
    Console.Write(array[i]+" ");

    if(array[i]== num)
    {
        isFind= "Да";
    }
}

System.Console.WriteLine(isFind);
