// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M 
//до N. 
// Использовать рекурсию, не использовать циклы.

using System;
class Solution {
  static void Main() {
    Console.WriteLine("Введите значение числа М:");
    int m = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите значение числа N:");
    int n = int.Parse(Console.ReadLine());
    SetOfNaturalNumbers(m, n);
  }
  static void SetOfNaturalNumbers(int numOne, int numTwo){
      if(numOne > numTwo){
          return;
      }
      if(numOne == numTwo){
          Console.Write(numOne + ".");
      }else{
          Console.Write(numOne + ", ");
      }
      numOne = numOne + 1;
      SetOfNaturalNumbers(numOne, numTwo);
  }
}