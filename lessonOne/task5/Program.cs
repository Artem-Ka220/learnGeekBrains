// Напишите программу, которая на вход принимает трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число: ");
int anyNum = Convert.ToInt32((Console.ReadLine()));

int result = anyNum % 10;
Console.WriteLine(result);
