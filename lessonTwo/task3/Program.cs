// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число: ");
int numOne = Convert.ToInt32(Console.ReadLine());

if(numOne % 7 == 0 && numOne % 23 == 0){
    System.Console.WriteLine("Да.");
}else{
    System.Console.WriteLine("Нет.");
}
