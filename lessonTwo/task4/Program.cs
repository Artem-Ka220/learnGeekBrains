// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

System.Console.WriteLine("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

if(numOne * numOne == numTwo || numTwo * numTwo == numOne){
    System.Console.WriteLine("Да.");
}else{
    System.Console.WriteLine("Нет.");
}