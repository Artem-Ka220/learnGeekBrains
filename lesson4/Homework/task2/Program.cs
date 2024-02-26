//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System;
class  Solution{
  static void Main() {
    Console.WriteLine("Введите любое целое число: ");
    int yourNumber = int.Parse(Console.ReadLine());
    
    int[] myNewArray = CreateArray(yourNumber);
    PrintArray(myNewArray);
    
    Console.WriteLine($"В массиве {EvenNumber(myNewArray)} чётных чисел(числа).");
  }
  static int[] CreateArray(int anyNum){
      Random rnd = new Random();
      int[] anyArray = new int[anyNum];
      for(int i = 0; i < anyArray.Length; i++){
          anyArray[i] = rnd.Next(100, 1000);
      }
      return anyArray;
  }
  static void PrintArray(int[] array){
      for(int i = 0; i < array.Length; i++){
          if(i == 0){
              Console.Write($"[ {array[i]}, ");
          }else if(i < array.Length - 1){
              Console.Write($"{array[i]}, ");
          }else{
              Console.Write($"{array[i]} ]");
          }
      }
      Console.WriteLine();
  }
  static int EvenNumber(int [] num){
      int count = 0;
      for(int i = 0; i < num.Length; i++){
          if(num[i] % 2 == 0){
              count++;
          }
      }
      return count;
  }
}