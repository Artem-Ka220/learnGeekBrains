// Напишите программу, которая на вход принимает одно число (N),
//а на входе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4."
//2 -> "-2, -1, 0, 1, 2."
Console.WriteLine("Введите число: ");
int yourNum = Convert.ToInt32((Console.ReadLine()));
int numNegative = -1 * yourNum;

while(numNegative <= yourNum){
    if(numNegative == yourNum){
        Console.Write(numNegative + ". ");
    }else{
    Console.Write(numNegative + ", ");
}
    numNegative++;
}