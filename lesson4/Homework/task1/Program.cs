// using System;
class Solution {
  static void Main() {
    Solution.EnterYuorNum();
  }
  

static void EnterYuorNum(){
    while(true){
      System.Console.WriteLine("Введите любое число: ");
      string enter = Console.ReadLine();
      if(enter == "q"){
        Console.WriteLine("Вы решили закончить ввод.");
        break;
      }
      
      bool result = int.TryParse(enter, out var yourNum);
      int i = 0;
      while(yourNum > 0){
        i = i + yourNum % 10;
        yourNum = yourNum / 10;
      }
      if(i % 2 == 0){
        Console.WriteLine($"Сумма цифр введённого числа равна {i} и делится на 2, а значит, что пора закругляться.");
        break;
      }
    }
}
}
