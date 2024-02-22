// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

// а = 25, b = 5 -> да 
// а = 2, b = 10 -> нет 
// а = 9, b = -3 -> да 
// а = -3, b = 9 -> нет

Console.WriteLine("Введите 1 число: ");
int numOne = Convert.ToInt32((Console.ReadLine()));

Console.WriteLine("Введите 2 число: ");
int numTwo = Convert.ToInt32((Console.ReadLine()));

if(numOne == numTwo * numTwo){
    Console.WriteLine("Да.");
}else{
    Console.WriteLine("Нет.");
}