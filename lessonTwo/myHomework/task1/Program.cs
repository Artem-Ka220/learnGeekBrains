// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите любое число: ");
int yourNum = int.Parse(Console.ReadLine());
    if(yourNum % 7 == 0 && yourNum % 23 == 0){
        System.Console.WriteLine("Введённое число одновременно кратно 7 и 23.");
    }else{
        System.Console.WriteLine("Введённое число не кратно одновременно числам 7 и 23.");
    }