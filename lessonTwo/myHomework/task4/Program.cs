// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите любое число: ");
int yourNum = Convert.ToInt32(Console.ReadLine());

while(yourNum >= 1){
    int num = yourNum % 10;
    if(yourNum < 10){
        System.Console.WriteLine($"{yourNum}.");
    }else{
        System.Console.Write($"{num}, ");
    }   
    yourNum = yourNum / 10;
}