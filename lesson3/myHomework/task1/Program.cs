// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,90].
using System;
using System.Linq;

class UserInputToCompileForTest
{     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
          int count = 0;
          for(int i = 0; i < numbers.Length; i++){
              if(numbers[i] >= minRange && numbers[i] <= maxRange){
                count++;
              }
          }
      return count;
    }
    
    public static void PrintResult(int[] array)
    {
          for(int i = 0; i < array.Length; i++){
            if(i == 0){
              Console.Write("{");
            }
            if(i < array.Length - 1){
              Console.Write($"{array[i]}, ");
            }else{
              Console.Write(array[i] + "}");
            }
          }
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            string joinedArgs = string.Join(" ", args);
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
        } else {
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; 
        }
        UserInputToCompileForTest.PrintResult(array);
        Console.WriteLine();
        Console.Write(UserInputToCompileForTest.CountItemsRange(array, 10, 90));
    }
}
