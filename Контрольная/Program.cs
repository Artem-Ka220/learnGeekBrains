using System;
class Solution {
  static void Main() {
    Console.WriteLine("Укажите длину массива: ");
    
    int size = int.Parse(Console.ReadLine());
    
    string[] anyArray = new string[size];
    
    int count = 0;
    while(count < anyArray.Length){
        Console.WriteLine($"Введите {count + 1} значение массива: ");
        anyArray[count] = Console.ReadLine();
        count++;
    }
    
    Console.WriteLine($"Наш массив - [{string.Join(", ", anyArray)}]");
    string[] array = NewArray(anyArray);
    Console.WriteLine($"Наш новый массив - [{string.Join(", ", array)}]");
  }
  
  static string[] NewArray(string[] someArray){
      string[] newArray = new string[someArray.Length];
      var rnd = new Random();
      int i = 0;
      foreach(var pair in someArray){
          int value = rnd.Next(0,4);
          newArray[i] = pair.Substring(0,value);
          i++;
      }
      return newArray;
  } 
}
