// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит,
// какое число большее,а какое меньшее.
using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if(firstNumber > secondNumber){
          Console.WriteLine("первое число больше");
        }else if(firstNumber < secondNumber){
          Console.WriteLine("второе число больше");
        }else{
          Console.WriteLine("числа равны");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 88;
            secondNumber = 88;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}