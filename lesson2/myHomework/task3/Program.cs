// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
Console.WriteLine("Введите любое целое число из отрезка от 10 до 99: ");
int anyNum = int.Parse(Console.ReadLine());

int numOne = anyNum % 10;
System.Console.WriteLine(numOne);
int numTwo = (anyNum - numOne) / 10;
System.Console.WriteLine(numTwo);

if(numOne > numTwo){
    System.Console.WriteLine($"Большое число - {numOne}.");
}else{
    System.Console.WriteLine($"Большое число - {numTwo}.");
}

