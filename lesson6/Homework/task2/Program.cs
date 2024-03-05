// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;
class Solution {
  static void Main() {
    Console.WriteLine("Введите строку, содержащую латинские буквы в обоих регистрах.");
    string str = Console.ReadLine();
   
    Console.WriteLine(str);
    Solution.PrintLower(str);
  }
  static void PrintLower(string any){
    any = any.ToLower();
    Console.WriteLine(any);
  }
}
