// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
using System;
class Solution {
  static void Main() {
    Console.WriteLine("Введите слово или число: ");
    string str = Console.ReadLine();
    Palindrome(str);
  }
  static void Palindrome(string any){
      string newWord = "";
      
      for(int i = any.Length - 1; i >= 0; i--){
          newWord = newWord + any[i];
      }
      Console.WriteLine("Ваше слово если читать наоборот, получится - " + newWord +".");
      
      int result = string.Compare(any,newWord);
      
      if(result < 0 || result > 0){
          Console.WriteLine("Строки неравны. Введённое слово не палиндром.");
      }else{
          Console.WriteLine("Ваше слово - палиндром! :)");
      }
  }
}


