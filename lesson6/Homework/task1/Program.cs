//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
using System;
class Solution {
  static void Main() {
    string str = "";
    char[] arr = {'Я',' ','л','ю','б','л','ю',' ','п','р','о','г','р','а','м','м','и','р','о','а','т','ь','.'};
    foreach(char letter in arr){
        str = str + letter;
    }
    Console.Write(str);
  }
}