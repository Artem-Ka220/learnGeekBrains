// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает и наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine(num);
int numOne = num/10;
int numTwo = num % 10;
if(numOne > numTwo){
    Console.WriteLine(numOne);
}else{
    Console.WriteLine(numTwo);
}
