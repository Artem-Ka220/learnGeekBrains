// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Linq;

class UserInputToCompileForTest
{ 
     
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        for(int i = 0; i < numbers.Length; i++){
            if(numbers[i] < min){
                min = numbers[i];
            }
        }
        return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double max = 0.0;
        for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] > max){
                max = numbers[i];
            }
        }
        return max;
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        double maxNum = FindMax(array);
        double minNum = FindMin(array);
        maxNum = maxNum - minNum;
        Console.WriteLine(maxNum);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}


