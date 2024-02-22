// // Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];
int[] array2 = new int [size/2];

for (int i = 0; i < array.Length ; i++)
{
    array[i]= new Random().Next(-10,11);
    Console.Write(array[i]+"\t");
}

System.Console.WriteLine();

for (int i = 0; i < array2.Length ; i++)
{
    array2[i]= array[i]* array[array.Length-1-i] ;
    Console.Write(array2[i]+"\t");
}
