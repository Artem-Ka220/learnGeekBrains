// // Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int GetSumNum(int number)
{
    if(number==0)
    {
        return 0;
    }

    return number%10+ GetSumNum(number/10);
}

System.Console.WriteLine(GetSumNum(num));
