// //Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
using System;
class  Solution{
  static void Main() {
    Console.WriteLine("Введите любое целое число: ");
    int yourNumber = int.Parse(Console.ReadLine());
    
    int[] myNewArray = CreateArray(yourNumber);
    PrintArray(myNewArray);
    
    int [] arr = TurnIt(myNewArray);
    PrintArray(arr);
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
 static int[] TurnIt(int [] someArray){
     int[] newArray = new int[someArray.Length];
     int count = 0;
     for(int i = someArray.Length - 1; i >= 0; i--){
         newArray[count] = someArray[i];
         count++;
     }
     return newArray;
 }
}
