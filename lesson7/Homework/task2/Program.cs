// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

using System;
class Solution {
  static void Main() {
      Console.WriteLine("Введите число М: ");
        int m = int.Parse(Console.ReadLine());
         Console.WriteLine("Введите число N: ");
          int n = int.Parse(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {A(m, n)}");
  }
static  int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m > 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}
}
