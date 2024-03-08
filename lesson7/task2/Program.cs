// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int firstNum=1;

void PrintNumbers(int start, int number)
{
    if(number <start)
    {
        return;
    }
    System.Console.Write(start+ " ");

    PrintNumbers(start+1,number);
}

PrintNumbers(firstNum,num);
