// // Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int numCopy= num;
int sizeNum=0;

while(numCopy>0)
{
    numCopy = numCopy/10;
    sizeNum= sizeNum+1;
}

int[] array = new int [sizeNum];

for (int i = 0; i < array.Length ; i++)
{
    array[i]= num%10;
    num= num/10;
    if(i == 0){
        System.Console.Write("[ ");
    }
    if(i < array.Length - 1){
    Console.Write($"{array[i]}, ");
    }else{
        System.Console.Write($"{array[i]} ]");
    }
}