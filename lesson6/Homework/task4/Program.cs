// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
using System;
class Solution {
  static void Main() {
    Console.WriteLine("Введите строку состоящую из строк или предложение: ");
    string yourString = Console.ReadLine();
    Console.WriteLine(yourString);
    Console.WriteLine();
    string[] myNewArray = StringSplit(yourString);
    PrintArray(myNewArray);
    string[] nArray = SwapString(myNewArray);
    PrintArray(nArray);
    string myNewString = JoinStringArray(nArray);
    Console.WriteLine(myNewString);
  }
  
  static string[] StringSplit(string someWord){
      string[] newArray = someWord.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
      return newArray;
  } 
  
  static string[] SwapString(string[] someStringArray){
      string[] newMyArray = new string[someStringArray.Length];
      
      int count = 0;
      
      for(int i = someStringArray.Length - 1; i >= 0; i--){
          newMyArray[count] = someStringArray[i];
          count++;
      }
      return newMyArray;
  }
  
  static void PrintArray(string[] anyArray){
      for(int i = 0; i < anyArray.Length; i++){
          if(i == 0){
              Console.Write("[ " + anyArray[i] + " ");
          }else if(i < anyArray.Length - 1){
              Console.Write(anyArray[i] + " ");
          }else{
              Console.Write(anyArray[i] + " ]");
          }
      }
      Console.WriteLine();
  }
  
  static string JoinStringArray(string[] array){
      string word = string.Join(" ", array);
      return word;
  }
}
